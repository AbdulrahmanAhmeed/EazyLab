using Client.Classes;
using Client.Reports;
//using CrystalDecisions.Shared;
using EazyLab;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MathNet.Numerics.Statistics;
using Microsoft.Reporting.WinForms;

namespace Client.Forms
{
    public partial class frmDataProcessing : Form
    {
        private RptDataBase RDB;
        public frmDataProcessing(Sample s)
        {
            InitializeComponent();
            RDB = new RptDataBase(s);
        }
        public frmDataProcessing()
        {
            InitializeComponent();

        }


        //public double GetAirFlow()
        //{

        //    System.Collections.Generic.List<double> l = new System.Collections.Generic.List<double>();
        //    foreach (Method method in Sample.Methods)
        //    {
        //        foreach (DataPacket dataPacket in method.Data)
        //        {
        //            l.Add(dataPacket.Airflow);
        //        }

        //    }


        //    return l.Count > 0 ? l.Average() : 0;
        //}


        //public void SetParameter(IParameterField parameter, string pName)
        //{

        //    //try
        //    //{

        //    //    System.Collections.Generic.List<double> l = new System.Collections.Generic.List<double>();
        //    //    foreach (Method method in Sample.Methods)
        //    //    {
        //    //        foreach (DataPacket dataPacket in method.Data)
        //    //        {
        //    //            object v = dataPacket.GetType().GetProperty(pName).GetValue(dataPacket, null);
        //    //            //  var property = dataPacket.GetType().GetRuntimeProperties().FirstOrDefault(p => p.Name == pName) ;


        //    //            l.Add(dataPacket.Airflow);
        //    //        }

        //    //    }

        //    //    rpt.SetParameterValue(parameter.ParameterFieldName, l.Average());
        //    //}
        //    //catch (Exception e)
        //    //{
        //    //    LoggerFile.WriteException(e);
        //    //}


        //}




        private void frmDataProcessing_Load(object sender, EventArgs e)
        {



            this.reportViewer1.RefreshReport();
            List<Customer> customerList = new List<Customer>();
            customerList.Add(Program.Chamber.Sample.Customer);
            reportViewer1.LocalReport.DataSources[0].Value = customerList;

            List<Sample> sampleList = new List<Sample>();
            sampleList.Add(Program.Chamber.Sample);
            reportViewer1.LocalReport.DataSources[1].Value = sampleList;

            List<Method> methodList = new List<Method>();

            foreach (var m in Program.Chamber.Sample.Methods)
            {
                methodList.Add(m);

            }
            reportViewer1.LocalReport.DataSources[2].Value = methodList;
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
