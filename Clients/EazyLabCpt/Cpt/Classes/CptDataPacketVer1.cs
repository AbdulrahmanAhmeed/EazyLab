using System;

namespace EazyLab.Cpt.Classes
{
    [Serializable]
    public class CptDataPacketVer1
    { 
        public DateTime  Time { set; get; }
        public int Id { get; set; }               
        public int TestId { set; get; }  
        public double Temp0 { set; get; }
        public double Temp1  { set; get; }
        public double Temp2 { set; get; }
        public double Temp3 { set; get; }
        public double Temp4 { set; get; } 
        public double Temp5 { set; get; }      
        public double Aux0 { set; get;}
        public double Aux1 { set; get; }
        public double Aux2 { set; get;}
        public double Aux3 { set; get;}
        public double Current_LR { set; get;}
        public double Voltage { set; get; }
        public double Current { set; get; }
        public double Power { set; get; }
        public double Energy { set; get; }
        public double Frequency { set; get; }
        public double Pf { set; get; }
        public UInt16 DigitalInput { set; get; }
        public UInt16 DigitalOutput { set; get; }
        public UInt16 Error { set; get; }
        public UInt16 Alarm { set; get; }
        public UInt16 Status { set; get; }
        public UInt64 MillisTime {  set; get; }
        public short WifiStrength { set; get; }



        public CptDataPacketVer1()
        {
           Time = DateTime.Now; 
            //Random rn = new Random();
            //Voltage = rn.Next();
            //Current = rn.Next();
            //Power = rn.Next();
            //PowerFactor = rn.Next();
            //Frequency = rn.Next();
            //Temp1 = rn.Next();
            //Temp2 = rn.Next();
            //Temp3 = rn.Next();
            //Temp4 = rn.Next();
            //Temp5 = rn.Next();
            //Temp6 = rn.Next();
            //Aux1 = rn.Next();
            //Aux2 = rn.Next();
            //Aux3 = rn.Next();
            //Aux4 = rn.Next();           
            
        }








    }


}
