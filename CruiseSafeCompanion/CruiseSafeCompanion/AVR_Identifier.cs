using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CruiseSafeCompanion
{
    public static class AVR_Identifier
    {
        public static string GetDeviceSignature(string portName)
        {
            Process avrprog = new Process();
            StreamReader avrstdout, avrstderr;
            StreamWriter avrstdin;

            string avrdude_exe = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RESOURCES", "avrdude.exe");
            string cmd = "\"{0}\" -carduino -patmega328 -b57600 -P{1}";

            cmd = string.Format(cmd, avrdude_exe, portName);
            ProcessStartInfo psi = new ProcessStartInfo("cmd");
            psi.UseShellExecute = false;
            psi.RedirectStandardError = true;
            psi.RedirectStandardInput = true;
            psi.RedirectStandardOutput = true;
            psi.CreateNoWindow = true;
            avrprog.StartInfo = psi;
            avrprog.Start();

            avrstdin = avrprog.StandardInput;
            avrstdout = avrprog.StandardOutput;
            avrstderr = avrprog.StandardError;

            avrstdin.AutoFlush = true;
            avrstdin.WriteLine(cmd);
            avrstdin.Close();

            string avrErr = avrstderr.ReadToEnd().ToUpper();

            Regex rgx = new Regex("DEVICE SIGNATURE = 0X(?'signature'[a-fA-F0-9]{6})");
            var match = rgx.Match(avrErr);

            if (match.Success)
            {
                return match.Groups["signature"].ToString();
            }
            else
            {
                MessageBox.Show("Could not match:\r\n" + avrErr); 
                return "";
            }
        }

        public static string GetDeviceName(string portName)
        {
            return SignatureToName(GetDeviceSignature(portName));
        }

        public static string SignatureToName(string signature)
        {
            if (string.IsNullOrEmpty(signature))
                return "UNKNOWN";

            string name = xDevices.Descendants("device")
                                .Where(device => device.Element("signature").Value == signature)
                                .FirstOrDefault().Element("name").Value;

            return name;
        }

        private static XDocument _xDevices;
        public static XDocument xDevices
        {
            get
            {
                if (_xDevices == null)
                    _initXDevices();
                return _xDevices;
            }
        }

        private static void _initXDevices()
        {
            string devices_xml = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "RESOURCES", "devices.xml");
            _xDevices = XDocument.Load(devices_xml);
        }
    }
}
