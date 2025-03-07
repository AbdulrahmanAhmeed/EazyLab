﻿using EazyLab.Classes;
using EazyLab.Cpt.Classes;
using EazyLab.Instrumentation.Plotting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
//using static Syncfusion.XlsIO.Parser.Biff_Records.AutoFilterRecord;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
namespace EazyLab.Cpt.Forms
{
    public partial class frmCptProfile : Form
    {
        DbAccess DbAccess = Server.DbAccess;
        CptProfile tempProfile { set; get; }
        CptTempZone tempZone { set; get; }
        List<string> BatchNumbers { get; set; } = new List<string>();
        CptModel model;
        private string BatchNumber ;
        List<CptProfile> tempProfiles = new List<CptProfile>();
        List<CptProfile> ModelsProfiles = new List<CptProfile>();
        List<CptModel> cptModels = new List<CptModel>();
        List<SampleSerialPrefix> sampleSerialPrefixes = new List<SampleSerialPrefix>();
        List<SampleSerialSuffix> sampleSerialSuffixes = new List<SampleSerialSuffix>();
        List<CptSample> cptSamples = new List<CptSample>();
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
            dudMax.Value = tempZone.Upper;
            dudTime.Value = tempZone.Time;
            dudMin.Value = tempZone.Lower  ;
        }
        private void TraceClicked(object sender, PlotChannelDataPointClickEventArgs e)
        {

            UpdateTempZoneGroup(e.Index);

        }

        private void frmCptTempProfile_Load(object sender, EventArgs e)
        {
            try
            {

                cptSamples = DbAccess.GetAll<CptSample>();
                cptSamples.ForEach(x =>
                {
                    if (x.BatchNumber != null && !BatchNumbers.Contains(x.BatchNumber))
                    {
                        BatchNumbers.Add(x.BatchNumber);
                    }
                });
                tempProfiles = cptSamples.Count==0? DbAccess.GetAll<CptProfile>() :cptSamples[0].Profiles;
                nudProfileId.Maximum = tempProfiles.Count==0 ? 1:tempProfiles.Count;
                cptModels = DbAccess.GetAll<CptModel>();
                cbModelName.DataSource = cptModels;
                cbBatchNumbers.DataSource = BatchNumbers;
                cbModelName.DisplayMember = "Model";
                cbModelName.SelectedIndex = cptModels.Count > 0 ? 0 : -1;
                if (tempProfiles.Count > 0) {
                    tempProfile = tempProfiles[0]; 
                }
                cbSource.DataSource = Enum.GetNames(typeof(CptProfile.ProfileSource));
                sampleSerialPrefixes = DbAccess.GetAll<SampleSerialPrefix>();
                cbPrefix.DataSource = sampleSerialPrefixes;
                sampleSerialSuffixes = DbAccess.GetAll<SampleSerialSuffix>();
                cbSuffix.DataSource = sampleSerialSuffixes;
                
                //listBox1.Items.AddRange(cptSamples.ToArray());
                tempsample = cptSamples;
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
            cptSamples = DbAccess.GetAll<CptSample>().Where(x => x.Model.Model == cbModelName.Text&& cbBatchNumbers.Text==x.BatchNumber).ToList();
            if (cptSamples.Count > 0)
            {
                listBox2.Items.Clear();
                listBox2.Items.AddRange(cptSamples[0].Profiles.Select(x => x.Source.ToString()).ToArray());
                ModelsProfiles = cptSamples[0].Profiles;
                tempsample = cptSamples;
                listBox1.Items.Clear();
                listBox1.Items.AddRange(tempsample.Select(x => x.SerialNo).ToArray());

            }
            if (tempsample.Count == 0)
            {
                listBox1.Items.Clear();
                listBox1.Items.AddRange(cptSamples.Select(x => x.SerialNo).ToArray());
            }
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
                    if(tempProfile != null )
                    {
                        cbSource.Text = tempProfile.Source.ToString();
                        groupBoxPoint.Enabled = true;
                        nudProfileId.Enabled = true;
                        nudProfileId.Maximum = tempProfiles.Count > tempProfile.Id? tempProfiles.Count : tempProfile.Id ;
                        nudProfileId.Minimum = 1;
                       
                        
                        tempProfile.TempZones.Sort((x, y) => x.Time.CompareTo(y.Time));
                        foreach (var p in tempProfile.TempZones)
                        {
                            plot.Channels[0].AddXY(p.Time, p.Upper);
                            plot.Channels[1].AddXY(p.Time, p.Lower);

                        }
                        if (tempProfile.TempZones.Count > 0) {
                            dudTime.Value = tempProfile.TempZones.Last().Time;
                            dudMax.Value = tempProfile.TempZones.Last().Upper;
                            dudMin.Value = tempProfile.TempZones.Last().Lower;
                        }
                        plot.XAxes[0].Tracking.ZoomToFitAll();
                        plot.YAxes[0].Tracking.ZoomToFitAll();
                        nudProfileId.Value = tempProfile.Id;
                    }
                }
                

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


                plot.Channels[0].AddXY(p.Time, p.Lower);
                plot.Channels[1].AddXY(p.Time, p.Lower + p.Upper);
                plot.Channels[2].AddXY(p.Time, p.Lower - p.Upper);
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
                    Upper = this.dudMax.Value,
                    Lower = this.dudMin.Value,
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
                //tempProfile.MaxCurrent = dudMaxCurrent.Value;
                //tempProfile.MinPowerFactor = dudMinPowerFactor.Value;
                //tempProfile.RejectIfPowerFactor = cbMinPowerFactor.Checked;
                //tempProfile.RejectIfCurrent = cbMaxCurrent.Checked;
                tempProfile.Source = (CptProfile.ProfileSource)Enum.Parse(typeof(CptProfile.ProfileSource), cbSource.Text);  // (cbSource.SelectedIndex)CptProfile.ProfileSource;
                DbAccess.Upsert(tempProfile);
                //tempProfiles = DbAccess.GetAll<CptProfile>();
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
                tempProfile.Id = tempProfiles.Any() ? tempProfiles.Last().Id + 1 : 1 ;  //tempProfiles.Last().Id+1 ;
                tempProfiles.Add(tempProfile);
                nudProfileId.Maximum = tempProfiles.Count;
                nudProfileId.Minimum = 1;
                nudProfileId.Value = tempProfiles.Count;
                this.dudMax.Value = 0;
                this.dudMin.Value = 0;
                this.dudTime.Value = 0;
                if (((Button)sender).Text == "Copy")
                {
                    foreach (var p in oldprofile.TempZones) tempProfile.Add(p);

                }
            }
            catch (Exception ex)
            {

                LoggerFile.WriteException(ex);
            }
        }

        private void nudProfileId_ValueChanged(object sender, EventArgs e)
        {
            tempProfile = tempProfiles.Where(x => x.Id == nudProfileId.Value).FirstOrDefault();
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
                //if (!tempProfiles.Exists(x => x.Id == tempProfile.Id))
                //{
                //    MessageBox.Show("this tempProfile is either not saved or not exists");
                //    return;

                //}
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
            try
            {
                if (cptSamples.Any(x => x.Model.Model == cptModels[cbModelName.SelectedIndex].Model))
                    DbAccess.Delete<CptSample>(cptSamples.Where(x => x.Model.Model == cptModels[cbModelName.SelectedIndex].Model).First());
                DbAccess.Delete(cptModels[cbModelName.SelectedIndex]);
                UpdatecbModelName();
                UpdateDisplay();
            }
            catch (Exception ex)
            {
                LoggerFile.WriteException(ex);
            } 

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

        List<CptSample> tempsample = new List<CptSample>();
        List<CptSample> NewSamples = new List<CptSample>();
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
            //listBox1.Items.Clear();
            try
            {
                for (int i = 0; i < nudQuantity.Value; i++)
                {
                    string newserial = cbPrefix.Text + (i + nudStartCount.Value).ToString() + cbSuffix.Text;
                    CptSample s = new CptSample() { SerialNo = newserial, Model = cptModels[cbModelName.SelectedIndex],BatchNumber = numBatch.Value.ToString() };
                    tempsample.Add(s);
                    NewSamples.Add(s);
                    listBox1.Items.Add(s.SerialNo);

                }
            }
            catch (Exception ex)
            {
            }

        }

        private void btnSaveGeneratedSamples_Click(object sender, EventArgs e)
        {
            //foreach (var s in tempsample)
            //{
            //    DbAccess.Upsert(s);

            //}
            
            tempsample.ForEach(x =>
            {
                if (x.Model.Model != model.Model)
                {
                    x.Model = model;
                }
            });
            tempsample = tempsample.Count == 0 ? cptSamples : tempsample;
            tempsample.ForEach(x => x.Profiles= ModelsProfiles);
            try
            {
                foreach (var sample in tempsample) {
                    DbAccess.Insert(sample);
                }

            }
            catch (Exception ex) { 
                LoggerFile.WriteException(ex);
            }
            foreach (var item in tempsample[0].Profiles)
            {
                DbAccess.Upsert(item);
            }
            //CptTest cptTest = new CptTest();

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
            //tempProfile.RejectIfPowerFactor = cbMinPowerFactor.Checked;
        }

        private void nudStartCount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbModelName_SelectedIndexChanged(object sender, EventArgs e)
        {
            model = (CptModel)cbModelName.SelectedItem;
            cbModelName.Text = model.Model;
            UpdateDisplay();
        }

        private void btnAddToModel_Click(object sender, EventArgs e)
        {
            if (!ModelsProfiles.Any(x => x.Source == tempProfile.Source))
            {
                ModelsProfiles.Add((CptProfile)tempProfile.Clone());
                listBox2.Items.Add(tempProfile.Source);
            }
            else
            {
                for(var i = 0; i<ModelsProfiles.Count ;i++)
                {
                    if (ModelsProfiles[i].Source == tempProfile.Source) ModelsProfiles[i] = tempProfile;
                }
            }
            //listBox1.Items.Add(tempProfile.Source);
        }

        private void btUpper_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = colorDialog1.ShowDialog();
            // = colorDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    
                    tempProfile.UpperLimitRGP = colorDialog1.Color.ToArgb();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Please Add New Profile");
                }
                //btColorDialog.BackColor = colorDialog1.Color;
            }
        }

        private void btLower_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = colorDialog1.ShowDialog();
            // = colorDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                try
                {

                    tempProfile.LowerLimitRGP = colorDialog1.Color.ToArgb();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Please Add New Profile");
                }
                //btColorDialog.BackColor = colorDialog1.Color;
            }
        }

        private void cbSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            tempProfile.Source = (CptProfile.ProfileSource)Enum.Parse(typeof(CptProfile.ProfileSource), cbSource.Text);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tempProfile = ModelsProfiles[listBox2.SelectedIndex];
                UpdateDisplay();
            }
            catch (Exception ex)
            {
                LoggerFile.WriteException(ex);
            }
        }

        private void btnNewModel_Click(object sender, EventArgs e)
        {
            cbModelName.Text = "";
            tempsample.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            ModelsProfiles.Clear();
        }

        private void label14_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void cbBatchNumbers_SelectionChangeCommitted(object sender, EventArgs e)
        {
            UpdateDisplay();
        }
    }
}
