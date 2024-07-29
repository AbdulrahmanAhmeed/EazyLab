using EazyLab.Model;
using LiteDB;
using System;
using System.Collections.Generic;
namespace EazyLab.Cpt.Classes
{

    [Serializable]
    public class CptTest : Entity
    {
        private  DateTime startTime = DateTime.MinValue;
        private LiteDatabase db;
        public const string IncludeString = "$.CptDataPacketVer1,$.Profile,$.Model";

        public List<CptDataPacketVer1> Data = new List<CptDataPacketVer1>();  // buffer to store the Datapacket
        public CptSample CptSample { get; set; }   
        public DateTime StartTime => startTime;
        public CptTest()
        {
            this.Name = "New Sample";   
        }

        public CptTest(LiteDatabase db)
        {
            this.Name = "New Sample"; // Naming strategy must be reevaluated 
            this.db = db;  

        }


        public override string ToString()
        {
            return this.Name;
        }

        public void Start()
        {
            startTime = DateTime.Now;
            Data= new List<CptDataPacketVer1>();

        }

        public void Add(CptDataPacketVer1 dp)
        {
            try
            {
                Data.Add(dp);
                dp.TestId = this.Id;
                db.GetCollection<CptDataPacketVer1>().Upsert(dp);

            }
            catch (Exception ex)
            {
                LoggerFile.WriteException(ex); 
            }
        }



    }



}
