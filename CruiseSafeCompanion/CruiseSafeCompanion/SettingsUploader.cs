using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;


namespace CruiseSafeCompanion
{
    class SettingsUploader
    {
        private string _portName;
        private CSC_File _file;

        private SerialPort _port;
        private string _sendString = "";

        private string _serialDataReceived = "";

        public SettingsUploader(string portName, CSC_File file)
        {
            _portName = portName;
            _file = file;
        }

        public void Upload()
        {
            try
            {
                _port = new SerialPort(_portName);
                _port.BaudRate = 9600;
                _port.DataReceived += _port_DataReceived;
                _port.Open();

                _sendString = _file.ToSerialString();
                _port.WriteLine(_sendString);
            }
            catch(Exception ex)
            {
                ErrorHandler.Handle(ex);
            }
        }

        private void _port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            System.Threading.Thread.Sleep(100);
            _serialDataReceived += _port.ReadExisting();

            if (_serialDataReceived.Contains("ACK"))
                System.Windows.Forms.MessageBox.Show("Upload erfolgreich!");
            else
                System.Windows.Forms.MessageBox.Show("Upload fehlgeschlagen!");
            _port.Close();
        }
    }
}
