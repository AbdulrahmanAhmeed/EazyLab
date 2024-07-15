

namespace Client.Classes
{
   public  class Power
    {
     // public   enum LineType { SingelPhase , ThreePhase}
        public Sample.PhasesType  Type { set; get; }
        public double Voltage { get; set; }
        public double Frequency { get; set; }
        AnalogInput VoltageCh { set; get; }
        AnChannel CurrentCh { set; get; }
        AnChannel FreqCh { set; get; }
        AnChannel PowerCh { set; get; }


         public Power(Sample.PhasesType type)
        {
            Type = type;
            //VoltageCh= Program.Server.AnChannels.Find(T => T.Name == Type.ToString()+ "Voltage:0");
            //CurrentCh = Program.Server.AnChannels.Find(T => T.Name == Type.ToString() + "Current:0");
            //FreqCh= Program.Server.AnChannels.Find(T => T.Name == Type.ToString() + "Frequency:0");
            //PowerCh = Program.Server.AnChannels.Find(T => T.Name == Type.ToString() + "Power:0");
        }



    }
}
