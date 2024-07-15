using EazyLab.Classes;
using EazyLab.Cpt.Classes;
using EazyLab.Instrumentation.Plotting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace EazyLab.Cpt.Forms
{
    public partial class frmCptProfile : Form
    {
        DbAccess DbAccess = Server.DbAccess;
        CptProfile tempProfile { set; get; }
        CptTempZone tempZone { set; get; }
        CptModel model;

        List<CptProfile> tempProfiles = new List<CptProfile>();
        List<CptModel> cptModels = new List<CptModel>();
        List<SampleSerialPrefix> sampleSerialPrefixes = new List<SampleSerialPrefix>();
        List<SampleSerialSuffix> sampleSerialSuffixes = new List<SampleSerialSuffix>();
        List<CptTest> cptSamples = new List<CptTest>();
        public frmCptProfile()
        {
            InitializeComponent();
            tempProfile = new CptProfile();
            ((PlotChannelTrace)plot.Channels[0]).DataPointClick += TraceClicked;
            ((PlotChannelTrace)plot.Channels[1]).DataPointClick += TraceClicked;
        }

        void UpdateTempZoneGroup(int i)
        {
            tempZone = tempProfile.TempZones[i];
            dudMax.Value = tempZone.Max;
            dudTime.Value = tempZone.Time;
            dudMin.Value = tempZone.Min  ;
        }
        private void TraceClicked(object sender, PlotChannelDataPointClickEventArgs e)
        {

            UpdateTempZoneGroup(e.Index);

        }

        private void frmCptTempProfile_Load(object sender, EventArgs e)
        {
            try
            {
                tempProfiles = DbAccess.GetAll<CptProfile>();
                cptModels = DbAccess.GetAll<CptModel>();
                cbModelName.DataSource = cptModels;
                cbModelName.DisplayMember = "Model";
                cbModelName.SelectedIndex = cptModels.Count > 0 ? 0 : -1;
                if (tempProfiles.Count > 0) { tempProfile = tempProfiles[0]; }
                cbSource.DataSource = Enum.GetNames(typeof(CptProfile.ProfileSource));
                sampleSerialPrefixes = DbAccess.GetAll<SampleSerialPrefix>();
                cbPrefix.DataSource = sampleSerialPrefixes;
                sampleSerialSuffixes = DbAccess.GetAll<SampleSerialSuffix>();
                cbSuffix.DataSource = sampleSerialSuffixes;
                cptSamples = DbAccess.GetAll<CptTest>();
                listBox1.Items.AddRange(cptSamples.ToArray());
                UpdateDisplay();
            }
            catch (Exception ex)
            {

                LoggerFile.WriteException(ex);
            }
        }

        /// <summary>
        /// Updates the display.
        /// </summary>
        void UpdateDisplay()
        {
            try
            {
                plot.Channels[0].Clear();
                plot.Channels[1].Clear();

                if (tempProfiles.Count == 0)
                {
                    nudProfileId.Enabled = false;
                    groupBoxPoint.Enabled = false;

                }
                else
                {
                    groupBoxPoint.Enabled = true;
                    nudProfileId.Enabled = true;
                    nudProfileId.Maximum = tempProfiles.Count;
                    nudProfileId.Minimum = 1;
                    nudProfileId.Value = tempProfile.Id;
                    tempProfile.TempZones.Sort((x, y) => x.Time.CompareTo(y.Time));
                    foreach (var p in tempProfile.TempZones)
                    {
                        plot.Channels[0].AddXY(p.Time, p.Max);
                        plot.Channels[1].AddXY(p.Time,  p.Min);

                    }
                    plot.XAxes[0].Tracking.ZoomToFitAll();
                    plot.YAxes[0].Tracking.ZoomToFitAll();
                }
                cptSamples = DbAccess.GetAll<CptTest>();
                listBox1.Items.AddRange(cptSamples.ToArray());

            }
            catch (Exception ex)
            {
                //MessageBox.Show("this profile is correupted it will be detele");
                //DbAccess.Delete<CptTempProfile>(tempProfile);

                LoggerFile.WriteException(ex);
            }

            //UpdateDisplay();




        }


        void plotpoint(CptTempZone p)
        {
            try

            {


                plot.Channels[0].AddXY(p.Time, p.Min);
                plot.Channels[1].AddXY(p.Time, p.Min + p.Max);
                plot.Channels[2].AddXY(p.Time, p.Min - p.Max);
                plot.XAxes[0].Tracking.ZoomToFitAll();
                plot.YAxes[0].Tracking.ZoomToFitAll();
            }
            catch (Exception ex)
            {
                LoggerFile.WriteException(ex);
            }

        }

        private void btnAddTempZone_Click(object sender, EventArgs e)
        {
            try
            {
                CptTempZone z = new CptTempZone()
                {
                    Max = this.dudMax.Value,
                    Min = this.dudMin.Value,
                    Time = this.dudTime.Value
                };

                tempProfile.Add(z);
                UpdateDisplay();
            }
            catch (Exception ex)
            {

                LoggerFile.WriteException(ex);
            }


        }

        private void btnDeleteTempZone_Click(object sender, EventArgs e)
        {
            try
            {
                // CptTempZone z = tempProfile.TempZones.First(z => z.Time == dudTime.Value);
                tempProfile.DelByTime(this.dudMax.Value);
                UpdateDisplay();

            }
            catch (Exception ex)
            {
                LoggerFile.WriteException(ex);
            };
        }






        private void btnSaveProfile_Click(object sender, EventArgs e)
        {

            if (tempProfile.TempZones.Count < 2) MessageBox.Show("Error : Profile must have at least two points");
            else
            {
                tempProfile.MaxCurrent = dudMaxCurrent.Value;
                tempProfile.MinPowerFactor = dudMinPowerFactor.Value;
                tempProfile.RejectIfPowerFactor = cbMinPowerFactor.Checked;
                tempProfile.RejectIfCurrent = cbMaxCurrent.Checked;
                DbAccess.Upsert(tempProfile);
                tempProfiles = DbAccess.GetAll<CptProfile>();
                //tempProfile = tempProfiles[(int)nudProfileId.Value - 1];
                UpdateDisplay();
            }


        }

        private void btnProfileDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DbAccess.Delete<CptProfile>(tempProfiles[(int)nudProfileId.Value - 1]);
                tempProfiles = DbAccess.GetAll<CptProfile>();
                if (tempProfiles.Count > 0)
                {
                    tempProfile = tempProfiles[0];
                    UpdateDisplay();

                }
                else
                {
                    nudProfileId.Maximum = 1;
                    nudProfileId.Minimum = 1;
                    nudProfileId.Value = 1;
                    nudProfileId.Enabled = false;
                }

            }
            catch (Exception ex)
            {

                LoggerFile.WriteException(ex);
            }
        }



        private void btnNewProfile_Click(object sender, EventArgs e)
        {
            try
            {
                var oldprofile = tempProfile;
                tempProfile = new CptProfile();
                tempProfile.Id= tempProfiles.Last().Id+1 ;
                tempProfiles.Add(tempProfile);
                nudProfileId.Maximum = tempProfiles.Count;
                nudProfileId.Minimum = 1;
                nudProfileId.Value = tempProfiles.Count;
                if (((Button)sender).Text == "Copy")
                {
                    foreach (var p in oldprofile.TempZones) tempProfile.Add(p);

                }
                UpdateDisplay();
            }
            catch (Exception ex)
            {

                LoggerFile.WriteException(ex);
            }
        }

        private void nudProfileId_ValueChanged(object sender, EventArgs e)
        {
            tempProfile = tempProfiles[(int)nudProfileId.Value - 1];
            UpdateDisplay();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void label1_TextChanged(object sender, EventArgs e)
        {

        }



        private void btModelSave_Click(object sender, EventArgs e)
        {
            try
            {
                model = new CptModel();
                model.Model = cbModelName.Text;
                if (!tempProfiles.Exists(x => x.Id == tempProfile.Id))
                {
                    MessageBox.Show("this tempProfile is either not saved or not exists");
                    return;

                }
                model.DefaultProfile = tempProfile;
                model.Created = DateTime.Now;
                model.InrushCurrent = dudInrushCurrent.Value;
                model.OverCurrent = dudOverCurrent.Value;
                model.DelayTime = (int)nudDelayTime.Value;
                if (cbModelName.Text == null)
                {
                    MessageBox.Show("Model name Can not be empty");
                    return;
                }
                //var dd = cptModels.FindAll(x=>x.Model == model.Model);                
                //foreach (var item in dd)
                //{
                //    if (model.Model == item.Model)
                //    {
                //        cptModels.Remove(item);
                //        DbAccess.Delete(item);
                //    }

                //}
                //cptModels.Add(model);
                DbAccess.Upsert<CptModel>(model, "Model");
                cptModels = DbAccess.GetAll<CptModel>();
                UpdatecbModelName();
            }
            catch (Exception ex)
            {
                LoggerFile.WriteException(ex);
            }
        }

        private void btModelDelete_Click(object sender, EventArgs e)
        {
            DbAccess.Delete(cptModels[cbModelName.SelectedIndex]);
            UpdatecbModelName();
        }
        void UpdatecbModelName()
        {
            cptModels = DbAccess.GetAll<CptModel>();
            cbModelName.DataSource = cptModels;
            cbModelName.DisplayMember = "Model";
        }
        void UpdateModelGroup()
        {
            model = cptModels[cbModelName.SelectedIndex];
            dudInrushCurrent.Value = model.InrushCurrent;
            dudOverCurrent.Value = model.OverCurrent;
            nudDelayTime.Value = model.DelayTime;
        }


        private void plot_DoubleClick(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void plot_Click(object sender, EventArgs e)
        {

            if (Cursor.Current == Cursors.Hand)
            {
                var pl = (Plot)sender;
                var ss = plot.DataCursors.XY;

            }

        }

        private void plot_CursorChanged(object sender, EventArgs e)
        {
            //if(Cursor.Current == Cursors.Hand)
            //MessageBox.Show(Cursor.Current.ToString());
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        List<CptTest> tempsample = new List<CptTest>();
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //tempsample.Clear();
            if (cbPrefix.Text != "")
            {
                var ss = cbPrefix.Text;
                var p = new SampleSerialPrefix() { Name = cbPrefix.Text };
                DbAccess.Upsert(p);
                cbPrefix.DataSource = DbAccess.GetAll<SampleSerialPrefix>();
                cbPrefix.DisplayMember = "Name";
                cbPrefix.Text = ss;

            }

            if (cbSuffix.Text != "")
            {
                var ss = cbSuffix.Text;
                var p = new SampleSerialSuffix() { Name = ss };
                DbAccess.Upsert(p);
                cbSuffix.DataSource = DbAccess.GetAll<SampleSerialSuffix>();
                cbPrefix.DisplayMember = "Value";
                cbSuffix.Text = ss;

            }
            if (nudQuantity.Value == 0) return;
            listBox1.Items.Clear();
            for (int i = 0; i < nudQuantity.Value; i++)
            {
                string newserial = cbPrefix.Text + (i + nudStartCount.Value).ToString() + cbSuffix.Text;
                CptTest s = new CptTest() { Name = newserial, Model = cptModels[cbModelName.SelectedIndex] };
                tempsample.Add(s);
                listBox1.Items.Add(s.Name);

            }

            UpdateDisplay();
        }

        private void btnSaveGeneratedSamples_Click(object sender, EventArgs e)
        {
            //foreach (var s in tempsample)
            //{
            //    DbAccess.Upsert(s);

            //}

            DbAccess.Upsert(tempsample);

        }

        private void label10_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbModelName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            UpdateModelGroup();
        }

        private void cbMinPowerFactor_CheckedChanged(object sender, EventArgs e)
        {
            tempProfile.RejectIfPowerFactor = cbMinPowerFactor.Checked;
        }
    }
}
