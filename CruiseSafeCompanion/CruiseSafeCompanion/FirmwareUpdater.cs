using System;
using System.Collections.Generic;
using System.Data;
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

        public static string GetDeviceVersion(string portName)
        {
            try
            {
                SerialPort port = new SerialPort(portName);
                port.BaudRate = 9600;
                port.Open();

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

        public void UpdateFirmware(string portName)
        {
            _portName = portName;

            Thread T = new Thread(new ThreadStart(T_WORK));
            T.SetApartmentState(ApartmentState.STA);
            T.Name = "CruiseSafe Updater";
            T.Priority = ThreadPriority.BelowNormal;
            T.Start();
        }

        private void T_WORK()
        {
            try
            {
                DataTable dtResult = DBConnect.GetQueryResult(DBCommand.GetNewestFirmware);
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
