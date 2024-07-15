using System;
using LiteDB;
using EazyLabClient;


namespace EazyLab.Cpt.Classes
{
    public class CptDbAccess: DbAccess
    {
        //public static LiteDatabase db;


        public CptDbAccess()
        {
            Initialize();
        }

        /// <summary>
        /// Initializes the Data Base Befor using it .
        /// </summary>
        public   void Initialize()
        {

            try
            {
                var mapper = BsonMapper.Global;
                db = new LiteDatabase(Program.DataFile);
                db.GetCollection<CptTempProfile>().EnsureIndex(x => x.Id);
                db.GetCollection<CptModel>().EnsureIndex(x => x.Name);
                mapper.Entity<CptModel>().Id(x => x.Model);
                mapper.Entity<SampleSerialSuffix>().Id(x => x.Value);
                mapper.Entity<SampleSerialPrefix>().Id(x => x.Value);
                mapper.Entity<CptSample>().Id(x => x.SerialNo);
                mapper.Entity<CptStation>().Id(x => x.SerialNumber);
            }
            catch (Exception ex)
            {

                LoggerFile.WriteException(ex);
            }
        }


    }
}