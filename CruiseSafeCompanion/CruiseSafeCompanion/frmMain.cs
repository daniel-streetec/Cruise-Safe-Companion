using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CruiseSafeCompanion
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            MessageBox.Show(ApplicationUpdater.CheckForNewerVersion().ToString());
        }
    }
}
