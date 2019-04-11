using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CruiseSafeCompanion
{
    class FirmwareUpdater
    {
        public delegate void UpdateCompleteHandler(UpdateCompleteEventArgs e);
        public event UpdateCompleteHandler UpdateComplete;

        private string _portName = "";

        public static string CheckForCurrentFirmwareVersion()
        {
            DataTable dtResult = DBConnect.GetQueryResult(DBCommand.GetNewestFirmVersionNo);
            if (dtResult != null)
                return (string)dtResult.Rows[0]["VERSION_NO"];
            else
                return "";
        }

        public static string GetDeviceEEPROM(string portName)
        {
            try
            {
                SerialPort port = new SerialPort(portName);
                port.BaudRate = 9600;
                port.Open();

                Thread.Sleep(500);

                DateTime timeoutTime = DateTime.Now.AddSeconds(15);
                string received = "";
                port.WriteLine("<eeprom?>");
                while (received.Contains(@"</EEPROM>") == false)
                {
                    if (DateTime.Now >= timeoutTime)
                        throw new TimeoutException("Timeout während der EEPROM-Anfrage");

                    received += port.ReadExisting();
                }

                port.Close();
                return received;
            }
            catch (Exception ex)
            {
                ErrorHandler.Handle(ex);
                return "";
            }
        }

        public static string GetDeviceVersion(string portName)
        {
            try
            {
                SerialPort port = new SerialPort(portName);
                port.BaudRate = 9600;
                port.Open();

                Thread.Sleep(500);

                DateTime timeoutTime = DateTime.Now.AddSeconds(5);
                string received = "";
                port.WriteLine("<version?>");
                while(received.Contains(Environment.NewLine) == false)
                {
                    if (DateTime.Now >= timeoutTime)
                        throw new TimeoutException("Timeout während der Versionsanfrage");

                    received += port.ReadExisting();
                }

                port.Close();
                return received;
            }
            catch(Exception ex)
            {
                ErrorHandler.Handle(ex);
                return "";
            }
        }

        public static string GetDeviceConfig(string portName)
        {
            try
            {
                SerialPort port = new SerialPort(portName);
                port.BaudRate = 9600;
                port.Open();

                Thread.Sleep(500);

                DateTime timeoutTime = DateTime.Now.AddSeconds(5);
                string received = "";
                port.WriteLine("<config?>");
                while (received.Contains(Environment.NewLine) == false)
                {
                    if (DateTime.Now >= timeoutTime)
                        throw new TimeoutException("Timeout während der Versionsanfrage");

                    received += port.ReadExisting();
                }

                port.Close();
                return received;
            }
            catch (Exception ex)
            {
                ErrorHandler.Handle(ex);
                return "";
            }
        }

        public static void PerformFactoryReset(string portName)
        {
            try
            {
                SerialPort port = new SerialPort(portName);
                port.BaudRate = 9600;
                port.Open();

                Thread.Sleep(500);

                DateTime timeoutTime = DateTime.Now.AddSeconds(5);
                string received = "";
                port.WriteLine("<reset>");
                while (received.Contains(Environment.NewLine) == false)
                {
                    if (DateTime.Now >= timeoutTime)
                        throw new TimeoutException("Timeout während des Werksresets");

                    received += port.ReadExisting();
                }

                port.Close();

                if (received.Contains("ACK"))
                    MessageBox.Show("Werksreset erfolgreich!");
            }
            catch (Exception ex)
            {
                ErrorHandler.Handle(ex);
            }
        }

        public void UpdateFirmware(string portName, bool isPB)
        {
            if (!isPB)
                UpdateFirmwareStd(portName);
            else
                UpdateFirmwarePB(portName);
        }

        public void UpdateFirmwareStd(string portName)
        {
            _portName = portName;

            Thread T = new Thread(new ThreadStart(T_WORK));
            //Thread T = new Thread(new ThreadStart(T_WORK_PB));
            T.SetApartmentState(ApartmentState.STA);
            T.Name = "CruiseSafe Updater";
            T.Priority = ThreadPriority.BelowNormal;
            T.Start();
        }

        public void UpdateFirmwarePB(string portName)
        {
            _portName = portName;
            Thread T = new Thread(new ThreadStart(T_WORK_PB));
            T.SetApartmentState(ApartmentState.STA);
            T.Name = "CruiseSafe Updater";
            T.Priority = ThreadPriority.BelowNormal;
            T.Start();
        }

        private void T_WORK_PB()
        {
            try
            {
                DataTable dtResult = DBConnect.GetQueryResult(DBCommand.GetNewestFirmware(true));
                if (dtResult != null)
                {
                    byte[] DATA = (byte[])dtResult.Rows[0]["PAYLOAD"];
                    string VERSION = (string)dtResult.Rows[0]["VERSION_NO"];
                    string CHANGELOG = (string)dtResult.Rows[0]["CHANGELOG"];
                    DateTime RELEASE_DATE = (DateTime)dtResult.Rows[0]["DATE_OF_RELEASE"];

                    string tmpFileName = System.IO.Path.GetTempPath() + Guid.NewGuid().ToString() + ".hex";

                    System.IO.File.WriteAllBytes(tmpFileName, DATA);

                    Process avrprog = new Process();
                    StreamReader avrstdout, avrstderr;
                    StreamWriter avrstdin;

                    string avrdude_exe = System.IO.Path.Combine(Application.StartupPath, "RESOURCES", "avrdude.exe");
                    string avrdude_conf = System.IO.Path.Combine(Application.StartupPath, "RESOURCES", "avrdude.conf");

                    if (File.Exists(avrdude_exe) == false)
                    {
                        MessageBox.Show("Could not find avrdude.exe!");
                        UpdateComplete?.Invoke(new UpdateCompleteEventArgs("", "", false));
                        return;
                    }
                    if (File.Exists(avrdude_conf) == false)
                    {
                        MessageBox.Show("Could not find avrdude.conf!");
                        UpdateComplete?.Invoke(new UpdateCompleteEventArgs("", "", false));
                        return;
                    }

                    //tmpFileName = @"C:\Users\danie\AppData\Local\Temp\arduino_build_51152\CC3_Enhancements.ino.hex";


                    // 0 => avrdude.exe 1 => avrdude.conf 2 => hex file 3=> COMX
                    string command = "\"{0}\" -C \"{1}\" -v -patmega328pb -carduino -b57600 -D -Uflash:w:\"{2}\":i -P {3}";
                    command = string.Format(command, avrdude_exe, avrdude_conf, tmpFileName, _portName);

                    ProcessStartInfo psI = new ProcessStartInfo("cmd");
                    psI.UseShellExecute = false;
                    psI.RedirectStandardInput = true;
                    psI.RedirectStandardOutput = true;
                    psI.RedirectStandardError = true;
                    psI.CreateNoWindow = true;
                    avrprog.StartInfo = psI;
                    avrprog.Start();
                    avrstdin = avrprog.StandardInput;
                    avrstdout = avrprog.StandardOutput;
                    avrstderr = avrprog.StandardError;
                    avrstdin.AutoFlush = true;
                    avrstdin.WriteLine(command);
                    avrstdin.Close();

                    string returnText = "";
                    //returnText = avrstdout.ReadToEnd();
                    returnText = avrstderr.ReadToEnd();

                    if (!returnText.Contains("bytes of flash verified")) {
                        Clipboard.SetText(returnText);
                        throw new Exception("Fehler während des Update-Prozesses. Weitere Informationen zur Sendung an null-bar in der Zwischenablage.");
                    }

                    UpdateComplete?.Invoke(new UpdateCompleteEventArgs(CHANGELOG, VERSION, true));
                }
            }
            catch(Exception ex)
            {
                ErrorHandler.Handle(ex);
                UpdateComplete?.Invoke(new UpdateCompleteEventArgs("", "", false));
            }
        }

        private void T_WORK()
        {
            try
            {
                DataTable dtResult = DBConnect.GetQueryResult(DBCommand.GetNewestFirmware(false));
                if (dtResult != null)
                {
                    byte[] DATA = (byte[])dtResult.Rows[0]["PAYLOAD"];
                    string VERSION = (string)dtResult.Rows[0]["VERSION_NO"];
                    string CHANGELOG = (string)dtResult.Rows[0]["CHANGELOG"];
                    DateTime RELEASE_DATE = (DateTime)dtResult.Rows[0]["DATE_OF_RELEASE"];

                    string tmpFileName = System.IO.Path.GetTempPath() + Guid.NewGuid().ToString() + ".hex";

                    System.IO.File.WriteAllBytes(tmpFileName, DATA);

                    var Uploader = new ArduinoUploader.ArduinoSketchUploader(
                        new ArduinoUploader.ArduinoSketchUploaderOptions
                        {
                            FileName = tmpFileName,
                            PortName = _portName,
                            ArduinoModel = ArduinoUploader.Hardware.ArduinoModel.NanoR3
                        });

                    Uploader.UploadSketch();

                    UpdateComplete?.Invoke(new UpdateCompleteEventArgs(CHANGELOG, VERSION, true));
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.Handle(ex);
                UpdateComplete?.Invoke(new UpdateCompleteEventArgs("", "", false));
            }
        }

        public class UpdateCompleteEventArgs : EventArgs
        {
            private string _changelog;
            private string _version;
            private bool _success;

            public string Changelog { get => _changelog;}
            public string Version { get => _version;}
            public bool Success { get => _success; }

            public UpdateCompleteEventArgs(string changelog, string version, bool success)
            {
                _version = version;
                _changelog = changelog;
                _success = success;
            }
        }
    }
}
