using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EazyLab.Classes;
using EazyLab.Model; 
namespace EazyLab.Cpt.Classes
{
    public  class CptModel : Entity
    {
        public const string IncludeString = "$.DefaultProfile";
        public string Model { get; set; }
        public double InrushCurrent { set; get; } = 5;
        public double OverCurrent { set; get; } = 10;
        public int DelayTime { set; get; } = 180;    //seconds 
        public int  InrushCurrentDuration { set; get; } = 50000;  //mseconds

        [BsonRef("CptTempProfile")]
        public CptProfile DefaultProfile { get; set; }  
    }
}
