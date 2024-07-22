using EazyLab.Model;
using LiteDB;
using System;
using EazyLab.Cpt.Classes;
namespace EazyLab
{
    public static    class InitializeDb 
    {
         static  BsonMapper mapper = BsonMapper.Global;
        public static void  Initialize(string fileName)
        { 
            Server.DbAccess = new DbAccess(fileName);
            
            ServerInit(Server.db);
            CptInit(Server.db);  //initilize Db for Cpt
        }


        public static void  CptInit(LiteDatabase db)
        {

            try
            {
                db.GetCollection<CptProfile>().EnsureIndex(x => x.Id);
                db.GetCollection<CptModel>().EnsureIndex(x => x.Model);
                db.GetCollection<CptTest>().EnsureIndex(x => x.Name);
                db.GetCollection<CptSample>().EnsureIndex(x => x.SerialNo);
                db.GetCollection<SampleSerialSuffix>().EnsureIndex(x => x.Name);
                db.GetCollection<SampleSerialPrefix>().EnsureIndex(x => x.Name);
                db.GetCollection<CptChamber>().EnsureIndex(x => x.Id);
                db.GetCollection<CptStation>().EnsureIndex(x => x.SerialNumber);
                db.GetCollection<CptTagController>().EnsureIndex(x => x.Name);
                mapper.Entity<CptModel>().Id(x => x.Model);
                //mapper.Entity<SampleSerialSuffix>().Id(x => x.Name);
                //mapper.Entity<SampleSerialPrefix>().Id(x => x.Name);
                //mapper.Entity<CptSample>().Id(x => x.Name);
                // mapper.Entity<CptStation>().Id(x => x.SerialNumber);

            }
            catch (Exception ex)
            {

                LoggerFile.WriteException(ex);
            }
        }

        public  static  void ServerInit(LiteDatabase db)
        {

            try
            {
                           
                db.GetCollection<AnalogInput>().EnsureIndex(x => x.Name);
                db.GetCollection<AnalogOutput>().EnsureIndex(x => x.Name);
                db.GetCollection<MathChannel>().EnsureIndex(x => x.Name);
                db.GetCollection<DigitalInput>().EnsureIndex(x => x.Name);
                db.GetCollection<DigitalOutput>().EnsureIndex(x => x.Name);
                db.GetCollection<CommChannel>().EnsureIndex(x => x.Name);
                db.GetCollection<Device>().EnsureIndex(x => x.Name);
                db.GetCollection<DaqTask>().EnsureIndex(x => x.Name);
                db.GetCollection<Calibration>().EnsureIndex(x => x.Name);
                db.GetCollection<Unit>().EnsureIndex(x => x.Name);
                db.GetCollection<PID>().EnsureIndex(x => x.Name);
                db.GetCollection<UnitConversion>().EnsureIndex(x => x.Name);
                db.GetCollection<Script>().EnsureIndex(x => x.Name);

                // Map the ID of the  tables 
                mapper.Entity<AnalogInput>().Id(x => x.Name);
                mapper.Entity<AnalogOutput>().Id(x => x.Name);
                mapper.Entity<MathChannel>().Id(x => x.Name);
                mapper.Entity<DigitalInput>().Id(x => x.Name);
                mapper.Entity<DigitalOutput>().Id(x => x.Name);
                mapper.Entity<CommChannel>().Id(x => x.Name);
                mapper.Entity<Device>().Id(x => x.Name);
                mapper.Entity<DaqTask>().Id(x => x.Name);
                mapper.Entity<Calibration>().Id(x => x.Name);
                mapper.Entity<Unit>().Id(x => x.Name);
                mapper.Entity<PID>().Id(x => x.Name);
                mapper.Entity<UnitConversion>().Id(x => x.Name);
                mapper.Entity<Script>().Id(x => x.Name);
            }
            catch (Exception ex)
            {

                LoggerFile.WriteException(ex);
            }
        }



    }
}
