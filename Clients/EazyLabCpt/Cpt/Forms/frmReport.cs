using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Reports;
namespace Client.Forms
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            EnglishCrystalReport EnRpt = new EnglishCrystalReport();
            EnRpt.SetParameterValue("ThermalPower", "2");
            crystalReportViewer1.ReportSource = EnRpt;
           // crystalReportViewer1.DataBindings = 
        }
    }
}
