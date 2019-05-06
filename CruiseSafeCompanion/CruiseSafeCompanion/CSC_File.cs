using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CruiseSafeCompanion
{
    class CSC_File
    {
        #region private protected fields
        private XDocument _xDocument;
        private string _fileName = "";
        #endregion

        #region properties
        public string FileName
        {
            get
            {
                return _fileName;
            }
            set
            {
                _fileName = value;
            }
        }

        public XDocument xDocument
        {
            get { return _xDocument; }
        }

        #region pressure limiter
        public bool EnableLimiter
        {
            get
            {
                return _xDocument.Element("FILE").Element("LIMITS").Elements("ENABLE").FirstOrDefault().Value.ToBoolSafe();
            }
            set
            {
                _xDocument.Element("FILE").Element("LIMITS").Elements("ENABLE").FirstOrDefault().Value = value.ToString();
            }
        }

        public double LimiterFront
        {
            get
            {
                return _xDocument.Element("FILE").Element("LIMITS").Elements("FRONT").FirstOrDefault().Value.ToDoubleSafe();
            }
            set
            {
                _xDocument.Element("FILE").Element("LIMITS").Elements("FRONT").FirstOrDefault().Value = value.ToString("0.0");
            }
        }

        public double LimiterRear
        {
            get
            {
                return _xDocument.Element("FILE").Element("LIMITS").Elements("REAR").FirstOrDefault().Value.ToDoubleSafe();
            }
            set
            {
                _xDocument.Element("FILE").Element("LIMITS").Elements("REAR").FirstOrDefault().Value = value.ToString("0.0");
            }
        }
        #endregion

        #region high pressure beep
        public bool EnableHighBeep
        {
            get
            {
                return _xDocument.Element("FILE").Element("BEEP_HIGH").Elements("ENABLE").FirstOrDefault().Value.ToBoolSafe();
            }
            set
            {
                _xDocument.Element("FILE").Element("BEEP_HIGH").Elements("ENABLE").FirstOrDefault().Value = value.ToString();
            }
        }

        public double HighBeepFront
        {
            get
            {
                return _xDocument.Element("FILE").Element("BEEP_HIGH").Elements("FRONT").FirstOrDefault().Value.ToDoubleSafe();
            }
            set
            {
                _xDocument.Element("FILE").Element("BEEP_HIGH").Elements("FRONT").FirstOrDefault().Value = value.ToString("0.0");
            }
        }

        public double HighBeepRear
        {
            get
            {
                return _xDocument.Element("FILE").Element("BEEP_HIGH").Elements("REAR").FirstOrDefault().Value.ToDoubleSafe();
            }
            set
            {
                _xDocument.Element("FILE").Element("BEEP_HIGH").Elements("REAR").FirstOrDefault().Value = value.ToString("0.0");
            }
        }
        #endregion

        #region LOW pressure beep
        public bool EnableLowBeep
        {
            get
            {
                return _xDocument.Element("FILE").Element("BEEP_LOW").Elements("ENABLE").FirstOrDefault().Value.ToBoolSafe();
            }
            set
            {
                _xDocument.Element("FILE").Element("BEEP_LOW").Elements("ENABLE").FirstOrDefault().Value = value.ToString();
            }
        }

        public double LowBeepFront
        {
            get
            {
                return _xDocument.Element("FILE").Element("BEEP_LOW").Elements("FRONT").FirstOrDefault().Value.ToDoubleSafe();
            }
            set
            {
                _xDocument.Element("FILE").Element("BEEP_LOW").Elements("FRONT").FirstOrDefault().Value = value.ToString("0.0");
            }
        }

        public double LowBeepRear
        {
            get
            {
                return _xDocument.Element("FILE").Element("BEEP_LOW").Elements("REAR").FirstOrDefault().Value.ToDoubleSafe();
            }
            set
            {
                _xDocument.Element("FILE").Element("BEEP_LOW").Elements("REAR").FirstOrDefault().Value = value.ToString("0.0");
            }
        }
        #endregion
        public bool RiseOnStart
        {
            get
            {
                return _xDocument.Element("FILE").Elements("RISE_ON_START").FirstOrDefault().Value.ToBoolSafe();
            }
            set
            {
                _xDocument.Element("FILE").Elements("RISE_ON_START").FirstOrDefault().Value = value.ToString();
            }
        }
        public bool BtInvert
        {
            get
            {
                if (_xDocument.Elements("BT_INVERT").Count() == 0)
                    _xDocument.Root.Add(new XElement("BT_INVERT", false));

                return _xDocument.Element("FILE").Elements("BT_INVERT").FirstOrDefault().Value.ToBoolSafe();
            }
            set
            {
                if (_xDocument.Elements("BT_INVERT").Count() == 0)
                    _xDocument.Root.Add(new XElement("BT_INVERT", false));

                _xDocument.Element("FILE").Elements("BT_INVERT").FirstOrDefault().Value = value.ToString();
            }
        }
        #endregion

        #region constructors
        public CSC_File()
        {
            _xDocument = new XDocument(
                new XElement("FILE",
                    new XElement("LIMITS",
                        new XElement("ENABLE", false),
                        new XElement("FRONT", 0.0),
                        new XElement("REAR", 0.0)),
                    new XElement("BEEP_HIGH",
                        new XElement("ENABLE", false),
                        new XElement("FRONT", 0.0),
                        new XElement("REAR", 0.0)),
                    new XElement("BEEP_LOW",
                        new XElement("ENABLE", false),
                        new XElement("FRONT", 0.0),
                        new XElement("REAR", 0.0)),
                    new XElement("RISE_ON_START", false),
                    new XElement("BT_INVERT", false))
                );
        }

        public CSC_File(string FileName)
        {
            _fileName = FileName;
            try
            {
                _xDocument = XDocument.Load(_fileName);
            }
            catch(Exception ex)
            {
                ErrorHandler.Handle(ex);
            }
        }
        #endregion

        #region functions
        public void Load(string fileName)
        {
            _fileName = fileName;
            _xDocument = XDocument.Load(fileName);
        }

        public void Save()
        {
            if (_fileName == "")
            {
                System.Windows.Forms.SaveFileDialog SFD = new System.Windows.Forms.SaveFileDialog();
                SFD.Filter = "CSC-Files (*.CSC)|*.CSC";
                SFD.RestoreDirectory = true;
                if (SFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    _fileName = SFD.FileName;
                else
                    return;
            }
            try
            {
                _xDocument.Save(_fileName);
            }
            catch (Exception ex)
            {
                ErrorHandler.Handle(ex);
            }
        }

        public const double barToPsi = 14.5038;

        public string ToSerialString()
        {
            int psiLimiterFront = (int)Math.Round(LimiterFront * barToPsi, 0);
            int psiLimiterRear = (int)Math.Round(LimiterRear * barToPsi, 0);

            int psiHighBeepFront = (int)Math.Round(HighBeepFront * barToPsi, 0);
            int psiHighBeepRear = (int)Math.Round(HighBeepRear * barToPsi, 0);

            int psiLowBeepFront = (int)Math.Round(LowBeepFront * barToPsi, 0);
            int psiLowBeepRear = (int)Math.Round(LowBeepRear * barToPsi, 0);

            int enLimiter = (EnableLimiter ? 1 : 0);
            int enHighBeep = (EnableHighBeep ? 1 : 0);
            int enLowBeep = (EnableLowBeep ? 1 : 0);
            int enRiseOnStart = (RiseOnStart ? 1 : 0);
            int btInvert = (BtInvert ? 1 : 0);

            string s = string.Format("{0:X2}{1:X2}{2:X2}{3:X2}{4:X2}{5:X2}{6:X2}{7:X2}{8:X2}{9:X2}{10:X2}",
                enLimiter,
                psiLimiterFront,
                psiLimiterRear,
                enHighBeep,
                psiHighBeepFront,
                psiHighBeepRear,
                enLowBeep,
                psiLowBeepFront,
                psiLowBeepRear,
                enRiseOnStart,
                btInvert);

            int CheckSum = (int)calcChecksum(s);
            s = s + string.Format("{0:X2}", CheckSum);

            return s;
        }

        private char calcChecksum(string s)
        {
            char checkSum = (char)0;

            for(int i=0; i<s.Length; i++)
            {
                checkSum ^= s[i];
            }

            return checkSum;
        }
        #endregion

    }
}
