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
                        new XElement("REAR", 0.0)))
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
        #endregion

    }
}
