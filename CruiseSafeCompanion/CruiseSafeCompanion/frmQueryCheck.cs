using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CruiseSafeCompanion
{
    public partial class frmQueryCheck : Form
    {
        public frmQueryCheck()
        {
            InitializeComponent();
        }

        private void btGo_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection CONN = DBConnect.Connection)
                {
                    MySqlCommand CMD = new MySqlCommand(tbQuery.Text, CONN);
                    CONN.Open();

                    MySqlDataAdapter ADAPTER = new MySqlDataAdapter(CMD);
                    DataTable dtResult = new DataTable();

                    ADAPTER.Fill(dtResult);

                    dgvResult.DataSource = dtResult;
                    dgvResult.Refresh();
                    CONN.Close();
                }
            }
            catch(Exception ex)
            {
                ErrorHandler.Handle(ex);
            }
        }
    }
}
