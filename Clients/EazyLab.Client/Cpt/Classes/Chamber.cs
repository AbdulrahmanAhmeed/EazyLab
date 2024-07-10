using EazyLab;
using EazyLab.Client.Classes;
using EazyLab.Equipments;
using EazyLab.Equipments.Equipments;
using EazyLab.Model;
using EazyLab.Utilties;
using System;
using System.Collections.Generic;

namespace Client.Classes
{

    [Serializable]
    public class Chamber
    {
        [NonSerialized]
        MethodRTU _activeMethod = new MethodRTU();
        [NonSerialized]

        public Calibration CoolCapacityCalibration;
        const int Number_Of_Samples = 4;
        
        public Sample Sample { set; get; }
      
        public List<Sample> Chamer_Samples= new List<Sample>();
        public AhuBase InDoorAhu { set; get; }
        public AhuBase OutDoorAhu { set; get; }
        public CodeTester CodeTester { set; get; }
        public List<DataPacketActu> Buffer = new List<DataPacketActu>();
        public DataPacketActu lastDataPacket;//{ set; get; }

        public Chamber()
        {

            InDoorAhu = new AhuBase("InDoor");
            OutDoorAhu = new AhuBase("OutDoor");
            CodeTester = new CodeTester("CodeTester");
            Sample = new Sample();
            Chamer_Samples.Add(Sample);
            //CoolCapacityCalibration =Server.Calibrations.First(T => T.Name == "CoolingCapacity");

        }

        public void Initialize()
        {
            if (InDoorAhu == null) InDoorAhu = new AhuBase("InDoor");
            if (OutDoorAhu == null) OutDoorAhu = new AhuBase("OutDoor");
            if (CodeTester == null) CodeTester = new CodeTester("CodeTester");
            //InDoorAhu.Server = Server;
            //OutDoorAhu.Server = Server;
            //CodeTester.Server = Server;
        }


        public MethodRTU ActiveMethod() => _activeMethod;
        public void ActivateMethod(int methodNo)
        {

            //InDoorAhu.DbTSetPoint = Sample.Methods[methodNo].InDoorDbt;
            //InDoorAhu.WbTSetPoint = Sample.Methods[methodNo].InDoorWbt;
            //OutDoorAhu.DbTSetPoint = Sample.Methods[methodNo].OutDoorDbt;
            //OutDoorAhu.WbTSetPoint = Sample.Methods[methodNo].OutDoorWbt;
          //  CodeTester.StaticPressSp = Sample.Methods[methodNo].StaticPressure;
            Sample.Methods[methodNo].Data.Clear();
        }


        public void ActivateMethod(MethodRTU method)
        {
            //InDoorAhu.DbTSetPoint = method.InDoorDbt;
            //InDoorAhu.WbTSetPoint = method.InDoorWbt;
            //OutDoorAhu.DbTSetPoint = method.OutDoorDbt;
            //OutDoorAhu.WbTSetPoint = method.OutDoorWbt;
           // CodeTester.StaticPressSp = method.StaticPressure;

        }



        public void ActivateCurrentMethod()
        {
           // ActivateMethod(Sample.GetCurrentMethod());

        }

        public bool IsStared()
        {
            return false;
            // return InDoorAhu.IsStarted && OutDoorAhu.IsStarted;
        }
        public void Start()
        {

            try
            {
                //Task.Factory.StartNew(InDoorAhu.Start1);
                //Task.Factory.StartNew(OutDoorAhu.Start1);
                CodeTester.Start();

            }
            catch (System.Exception ex)
            {

                LoggerFile.WriteException(ex);
            }
        }

        public void Restart()
        {
            //InDoorAhu.restart();
            //OutDoorAhu.restart();
            CodeTester.Start();

        }

        public void Stop()
        {
            try
            {
                CodeTester.Stop();
                //Task.Factory.StartNew(InDoorAhu.Stop1);
                //Task.Factory.StartNew(OutDoorAhu.Stop1);

            }
            catch (System.Exception ex)
            {

                LoggerFile.WriteException(ex);
            }

        }


        public void UpdateReadings()
        {
            //InDoorAhu.UpdateReadings();
            //OutDoorAhu.UpdateReadings();
            CodeTester.UpdateReadings();

        }

        public Chamber Load(string file)
        {

            try
            {
                return (Chamber)SerializeObject.Load(file);



            }
            catch (Exception ex)
            {

                LoggerFile.WriteException(ex);
            }

            return null;
        }


        public bool Save(string fileName)
        {
            try
            {
                return SerializeObject.Save(this, fileName);

            }
            catch (Exception ex)
            {

                LoggerFile.WriteException(ex);

            }
            return false;
        }


    }
}
