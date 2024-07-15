using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json; 
namespace EazyLab.Classes
{
    public  class CommDataPacket
    {
        public String Command { set; get; }
        public String SampleCode { set; get; }
        public String StationCode { set; get; }
        public String Data { set; get; }

        public string Serialize ()
        {
            return    JsonSerializer.Serialize(this);
        }

     
        public static  CommDataPacket DeSerializer(string data )
        {
           
            try
            {
                var tempstring = data.TrimEnd(new char[] { '\0' });
                var obj = (CommDataPacket)JsonSerializer.Deserialize<CommDataPacket>(tempstring)  ;
                return obj ;
            }
            catch (Exception ex)
            {
                LoggerFile.WriteException(ex); 
            }
            return null;
        }
        public static CommDataPacket DeSerializer(byte[] arrayData)
        {
            try
            {
                string tempstring = System.Text.Encoding.Default.GetString(arrayData);
                CommDataPacket? obj = JsonSerializer.Deserialize<CommDataPacket>(tempstring,JsonSerializerOptions.Default);
            }
            catch (Exception ex)
            {

                LoggerFile.WriteException(ex);
            }
            return null;
        }

    }
}
