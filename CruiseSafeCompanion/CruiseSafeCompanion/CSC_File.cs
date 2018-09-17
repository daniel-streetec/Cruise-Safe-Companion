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
        public double LimitFL
        {
            get
            {
                return _xDocument.Element("FILE").Element("LIMITS").Elements("FL").FirstOrDefault().Value.ToDoubleSafe();
            }
            set
            {
                _xDocument.Element("FILE").Element("LIMITS").Elements("FL").FirstOrDefault().Value = value.ToString("0.0");
            }
        }

        public double LimitFR
        {
            get
            {
                return _xDocument.Element("FILE").Element("LIMITS").Elements("FR").FirstOrDefault().Value.ToDoubleSafe();
            }
            set
            {
                _xDocument.Element("FILE").Element("LIMITS").Elements("FR").FirstOrDefault().Value = value.ToString("0.0");
            }
        }

        public double LimitRL
        {
            get
            {
                return _xDocument.Element("FILE").Element("LIMITS").Elements("RL").FirstOrDefault().Value.ToDoubleSafe();
            }
            set
            {
                _xDocument.Element("FILE").Element("LIMITS").Elements("RL").FirstOrDefault().Value = value.ToString("0.0");
            }
        }

        public double LimitRR
        {
            get
            {
                return _xDocument.Element("FILE").Element("LIMITS").Elements("RR").FirstOrDefault().Value.ToDoubleSafe();
            }
            set
            {
                _xDocument.Element("FILE").Element("LIMITS").Elements("RR").FirstOrDefault().Value = value.ToString("0.0");
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

        public double HighBeepFL
        {
            get
            {
                return _xDocument.Element("FILE").Element("BEEP_HIGH").Elements("FL").FirstOrDefault().Value.ToDoubleSafe();
            }
            set
            {
                _xDocument.Element("FILE").Element("BEEP_HIGH").Elements("FL").FirstOrDefault().Value = value.ToString("0.0");
            }
        }

        public double HighBeepFR
        {
            get
            {
                return _xDocument.Element("FILE").Element("BEEP_HIGH").Elements("FR").FirstOrDefault().Value.ToDoubleSafe();
            }
            set
            {
                _xDocument.Element("FILE").Element("BEEP_HIGH").Elements("FR").FirstOrDefault().Value = value.ToString("0.0");
            }
        }

        public double HighBeepRL
        {
            get
            {
                return _xDocument.Element("FILE").Element("BEEP_HIGH").Elements("RL").FirstOrDefault().Value.ToDoubleSafe();
            }
            set
            {
                _xDocument.Element("FILE").Element("BEEP_HIGH").Elements("RL").FirstOrDefault().Value = value.ToString("0.0");
            }
        }

        public double HighBeepRR
        {
            get
            {
                return _xDocument.Element("FILE").Element("BEEP_HIGH").Elements("RR").FirstOrDefault().Value.ToDoubleSafe();
            }
            set
            {
                _xDocument.Element("FILE").Element("BEEP_HIGH").Elements("RR").FirstOrDefault().Value = value.ToString("0.0");
            }
        }
        #endregion

        #region LOW pressure beep
        public bool EnableLOWBeep
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

        public double LOWBeepFL
        {
            get
            {
                return _xDocument.Element("FILE").Element("BEEP_LOW").Elements("FL").FirstOrDefault().Value.ToDoubleSafe();
            }
            set
            {
                _xDocument.Element("FILE").Element("BEEP_LOW").Elements("FL").FirstOrDefault().Value = value.ToString("0.0");
            }
        }

        public double LowBeepFR
        {
            get
            {
                return _xDocument.Element("FILE").Element("BEEP_LOW").Elements("FR").FirstOrDefault().Value.ToDoubleSafe();
            }
            set
            {
                _xDocument.Element("FILE").Element("BEEP_LOW").Elements("FR").FirstOrDefault().Value = value.ToString("0.0");
            }
        }

        public double LowBeepRL
        {
            get
            {
                return _xDocument.Element("FILE").Element("BEEP_LOW").Elements("RL").FirstOrDefault().Value.ToDoubleSafe();
            }
            set
            {
                _xDocument.Element("FILE").Element("BEEP_LOW").Elements("RL").FirstOrDefault().Value = value.ToString("0.0");
            }
        }

        public double LowBeepRR
        {
            get
            {
                return _xDocument.Element("FILE").Element("BEEP_LOW").Elements("RR").FirstOrDefault().Value.ToDoubleSafe();
            }
            set
            {
                _xDocument.Element("FILE").Element("BEEP_LOW").Elements("RR").FirstOrDefault().Value = value.ToString("0.0");
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
                        new XElement("FL", 0.0),
                        new XElement("FR", 0.0),
                        new XElement("RR", 0.0),
                        new XElement("RL", 0.0)),
                    new XElement("BEEP_HIGH",
                        new XElement("ENABLE", false),
                        new XElement("FL", 0.0),
                        new XElement("FR", 0.0),
                        new XElement("RR", 0.0),
                        new XElement("RL", 0.0)),
                    new XElement("BEEP_LOW",
                        new XElement("ENABLE", false),
                        new XElement("FL", 0.0),
                        new XElement("FR", 0.0),
                        new XElement("RR", 0.0),
                        new XElement("RL", 0.0)))
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
