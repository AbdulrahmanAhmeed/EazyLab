using EazyLab.Model;
using System;
using System.Collections.Generic;
namespace EazyLab.Cpt.Classes
{

    [Serializable]
    public class CptTest : Entity
    {
        public const string IncludeString = "$.CptDataPacketVer1,$.Profile,$.Model";

        public List<CptDataPacketVer1> Data = new List<CptDataPacketVer1>();  // buffer to store the Datapacket
        public List< CptProfile> Profiles {  get; set; }
        public CptModel Model { get; set; }
        public string SerialNo { set; get; }         
        public CptTest()
        {
            this.Name = "New Sample";   
        }


        public override string ToString()
        {
            return this.Name;
        }






    }



}
