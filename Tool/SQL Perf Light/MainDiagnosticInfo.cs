using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Perf_Light
{
    public partial class MainDiagnosticInfo : Form
    {
        public MainDiagnosticInfo()
        {
            InitializeComponent();
        }

        private void btnSQLServer_Click(object sender, EventArgs e)
        {
            Form1 sqlServerObj = new Form1();
            sqlServerObj.Show();
        }

        private void btnAzureSQLServer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In Progress");
        }

        private void btnAzureDataLake_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In Progress");
        }

        private void btnSSIS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In Progress");
        }

        private void btnSSRS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In Progress");
        }

        private void btnSSASTabular_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In Progress");
        }

        private void btnPowerBI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In Progress");
        }

        private void btnDAX_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In Progress");
        }

        private void btnAzureSynapse_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In Progress");
        }

        private void MainDiagnosticInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
