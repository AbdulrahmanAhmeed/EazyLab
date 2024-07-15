using Client.Classes;
using Client.Forms;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client;

public partial class frmTempDisp : Form
{
    
    public frmTempDisp()
    {
        InitializeComponent();
    }
    public double Time = 0;
    private List<PV> PvLists = new List<PV>();
    int graphUpdatePeriod = 6;
    private void switchLed1_ValueChanged(object sender, EazyLab.Classes.ValueBooleanEventArgs e)
    {

        if (e.ValueNew)
        {
            Chamber.Server.Initialize();
            Chamber.Server.Start();
            Time = 0;
            timerUpdate.Start();

        }
        else
        {
            timerUpdate.Stop();
            Chamber.Server.Stop();
        }
    }
    public bool serviceMode = false; 
    private void sbSetUp_DropDowItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
        if (!serviceMode)
        {
            frmServicePass passform = new frmServicePass();
            passform.ShowDialog();
            string passres = passform.result;
            if (passres != "naria12345") return;
            serviceMode = true; 
        }
        Cursor = System.Windows.Forms.Cursors.WaitCursor;
        Form frm = new Form();

        switch (e.ClickedItem.Text)
        {
            case "Application Settings":
                frm = new EzData.Forms.FrmAppSettings();
                break;
            case "Comm Channels":
                frm = new EzData.Forms.FrmCommChannels();
                break;
            case "Devices":
                frm = new EzData.Forms.frmDevices();
                break;
            case "Tasks":
                frm = new EzData.Forms.frmDaqTasks();
                break;
            case "Analog Channels":
                frm = new EzData.Forms.frmAnChannels();
                break;
            case "Digital Channels":
                frm = new EzData.Forms.frmDigChannels();
                break;
            case "Calibrations":
                frm = new EzData.Forms.FrmCalibrations();
                break;
            case "PID loops":
                frm = new EzData.Forms.frmPIDs();
                break;

            case "In Door":
                frm = new Client.Forms.frmHardwareChamber(Client.Program.Chamber.InDoorAhu);

                break;
            case "Out Door":
                frm = new Client.Forms.frmHardwareChamber(Client.Program.Chamber.OutDoorAhu);

                break;
            case "Code Tester":
                frm = new frmHardwareCodeTester(Client.Program.Chamber.CodeTester);
                break;
        }
        timerUpdate.Stop();
        Hide();
        frm.StartPosition = FormStartPosition.CenterScreen;
        frm.ShowDialog();

        Show();
        if (Client.Program.Server.IsStarted)
        {
            tBConnect.ToggleState = Syncfusion.Windows.Forms.Tools.ToggleButtonState.Active;
        }
        else
        {
            tBConnect.ToggleState = Syncfusion.Windows.Forms.Tools.ToggleButtonState.Inactive;
        }

        frm.Dispose();
        Cursor = System.Windows.Forms.Cursors.Default;
        timerUpdate.Start();
    }

    private void bHome_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void frmDisplayTemp_Load(object sender, EventArgs e)
    {
        lastUpatedTime = DateTime.Now;
        PvLists = EazyLab.Instrumentation.WF40.Combined.PV.GetAll(this);

        foreach (PV pv in PvLists)
        {
            pv.Initialize();
            pv.Plot = combinedPlot1;
        }

        graphUpdatePeriod = (int)(numericUpDownGraph.Value * 60);
    }
    DateTime lastUpatedTime;
    private void timerUpdate_Tick(object sender, EventArgs e)
    {
        Time += timerUpdate.Interval;
        combinedPlot1.Update(Time / 1000);
        if ((DateTime.Now - lastUpatedTime).TotalSeconds > graphUpdatePeriod)
        {
            // combinedPlot1.Update1(DateTime.Now);
           
            lastUpatedTime = DateTime.Now;
        }

        foreach (PV pv in PvLists)
        {
            try
            {
                pv.EzUpdate();
            }
            catch (Exception ex)
            {
                EazyLab.LoggerFile.WriteException(ex);
            }


        }


        if (Program.Server.IsStarted)
        {
            UpdateDisplay();
            ledServer.Value.AsBoolean = !ledServer.Value.AsBoolean;



        }
    }
    private void bSettings_Click(object sender, EventArgs e)
    {
        Cursor = System.Windows.Forms.Cursors.WaitCursor;
        Client.Forms.f frm = new Client.Forms.f(Client.Program.Chamber.Sample);
        Hide();
        DialogResult res = frm.ShowDialog();
        if (res == DialogResult.OK)
        {
            Client.Program.Chamber.Sample = frm.Sample;
        }

        frm.Dispose();
        GC.Collect();

        Show();
        Cursor = System.Windows.Forms.Cursors.Default;
        UpdateTitleBar();
    }

    private void sButtonHardware_Click(object sender, EventArgs e)
    {

    }

    private void bSample_Click(object sender, EventArgs e)
    {

        Start();
    }

   public  new  void Hide()
    {
        base.Hide();
        timerUpdate.Enabled = false;
    }

    public new void Show()
    {
        base.Show();
        timerUpdate.Enabled = true;
    }

    public virtual void Start()
    {


    }

    private void sbSystem_Click(object sender, EventArgs e)
    {

    }


    public void disableHardwareButtons()
    {
        sbSetUp.DropDownItems[9].Enabled = false;
        sbSetUp.DropDownItems[10].Enabled = false;
        sbSetUp.DropDownItems[11].Enabled = false;

    }

    public void enableHardwareButtons()
    {
        sbSetUp.DropDownItems[9].Enabled = true;
        sbSetUp.DropDownItems[10].Enabled = true;
        sbSetUp.DropDownItems[11].Enabled = true;

    }

    public virtual void LoadDataProcessingForm()
    {

        Cursor = System.Windows.Forms.Cursors.WaitCursor;
        Client.Forms.frmDataProcessing frm = new frmDataProcessing();
        Hide();
        frm.ShowDialog();
        Show();
        Cursor = System.Windows.Forms.Cursors.Default;
    }
    private void bProcessing_Click(object sender, EventArgs e)
    {
        LoadDataProcessingForm();

    }


    public virtual void UpdateDisplay()
    {

    }


    public void ConnectingServer()
    {

        Chamber.Server.Start();
        Time = 0;
        timerUpdate.Start();
        displayStringStatus.Value = Chamber.Server.IsStarted ? " Server Started" : "Starting Server failed";

    }

    public void DisconnectServer()
    {

        timerUpdate.Stop();
        Chamber.Server.Stop();
        displayStringStatus.Value = Chamber.Server.IsStarted ? "Stopping Server failed" : " Server Stopped";

    }

    private void tBConnect_Click(object sender, EventArgs e)
    {

        if (tBConnect.ToggleState == Syncfusion.Windows.Forms.Tools.ToggleButtonState.Inactive) ConnectingServer();
        else DisconnectServer();


    }

    private void label3_Click(object sender, EventArgs e)
    {

    }



    public virtual void UpdateTitleBar()
    {

    }

    private void led1_ValueChanged(object sender, EazyLab.Classes.ValueBooleanEventArgs e)
    {
        sbSetUp.Enabled = true;
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
        // sbSetUp.Enabled = true;
    }

    private void displayStringStatus_ValueChanged(object sender, EazyLab.Classes.ValueStringEventArgs e)
    {

    }

    private void ledServer_DoubleClick(object sender, EventArgs e)
    {
        sbSetUp.Enabled = true;
    }

    public virtual void MaxmizePlot()
    {

    }
    private void Button1_Click(object sender, EventArgs e)
    {
        MaxmizePlot();
    }

    private void NumericUpDownGraph_ValueChanged(object sender, EventArgs e)
    {
        graphUpdatePeriod = (int)(numericUpDownGraph.Value * 60);
    }
}

