using BarcodeStandard;
using SkiaSharp;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace EazyLab.Cpt.Forms
{

    public partial class frmBarcodeScannerRegist : Form
    {
       

        Barcode b = new Barcode();
       

        const bool CaptureOnlyInForeground = true;
        public frmBarcodeScannerRegist()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            b.IncludeLabel = true;
            var img = b.Encode(BarcodeStandard.Type.Code128, "Please Scan Me", SKColors.Black, SKColors.White, panel1.Width, panel1.Height);
            panel1.BackgroundImage = Image.FromStream(img.Encode().AsStream());




        }
   




        string sss = null;
       //  Devicelist;
        //private void Textbox_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    char c = e.KeyChar;
        //    var hd = new HidDevice();
        //    try
        //    {
        //        if (c == (char)Keys.Enter)
        //        {
        //            //MessageBox.Show(sss);
        //            var devicelist = hd.Enumerate();

        //            //foreach (var devic in devicelist)
        //            //{
        //            //    HidDevice dev = new HidDevice();
        //            //    dev.Read(100);


        //            //}
        //            if (sss == "Please Scan Me")
        //            {

        //                var img = b.Encode(BarcodeStandard.Type.Code128, "Please ReScan Me", SKColors.Black, SKColors.White, panel1.Width, panel1.Height);
        //                panel1.BackgroundImage = Image.FromStream(img.Encode().AsStream());
        //            }

        //            if (sss == "Please ReScan Me")
        //            {

        //                //devicelist = SharpLib.Win32.RawInput.PopulateDeviceList().FindAll(X => X.dwType == RawInputDeviceType.RIM_TYPEKEYBOARD);
        //                var img = b.Encode(BarcodeStandard.Type.Code128, "Please Scan Me to finish", SKColors.Black, SKColors.White, panel1.Width, panel1.Height);
        //                panel1.BackgroundImage = Image.FromStream(img.Encode().AsStream());
        //            }

        //            sss = "";

        //        }
        //        else sss = sss + c;
        //    }
        //    catch (Exception ex)
        //    {

        //        LoggerFile.WriteException(ex);
        //    }




        //}

        void CleaerDisplay()
        {
            this.Controls.Clear();
        }
        void DisplayMessage(string message)
        {
            this.Controls.Clear();
            Label label = new Label();
            label.Dock = DockStyle.Fill;
            label.Text= message; 
            this.Controls.Add(label);
        }



        string DeviceName { get; set; }




        /// <summary>
        /// Populate our tree view with our devices.
        /// </summary>
        private void PopulateDeviceList()
        {

        }

        private void frmBarcodeScannerRegist_Load(object sender, EventArgs e)
        {

        }
    }
}
