using EazyLab;
using EazyLabClient;
using System;
namespace Client.Classes
{
    [Serializable]
    public struct DataPacket
    {

        private double _ew_corr;
        private double _eCodeTester;
        private double _coolingCapacity;
        private DateTime _Time;
        private double _InDoorDbt;
        private double _InDoorHum;
        private double _InDoorWbt;
        private double _OutDoorDbt;
        private double _OutDoorHum;
        private double _OutDoorWbt;
        private double _Voltage;
        private double _Current;
        private double _Power;
        private double _Frequency;
        private double _PowerFactor;
        private double _CodeTesterDbT;
        private double _CodeTesterWbt;
        private double _AtmosphericPress;
        private double _NozzlePress;
        private double _StaticPress;
        public DateTime Time => _Time;
        public double InDoorDbt { set => _InDoorDbt = value; get => _InDoorDbt; }
        public double InDoorHum { get => _InDoorHum; }
        public double InDoorWbt { set => _InDoorWbt = value; get => _InDoorWbt; }
        public double OutDoorDbt { set => _OutDoorDbt = value; get => _OutDoorDbt; }
        public double OutDoorHum { get => _OutDoorHum; }
        public double OutDoorWbt { set => _OutDoorWbt = value; get => _OutDoorWbt; }
        public double CoolCapSSD { set; get; }
        public double Voltage
        {
            get => _Voltage;
            set => _Voltage = value;
        }
        public double Current { get => _Current; }
        public double Power { get => _Power; }
        //public double Energy { get => _energy; }
        public double PowerFactor { get => _PowerFactor; }
        public double Frequency
        {
            get => _Frequency;
            set => _Frequency = value;
        }
        public double SampleDbT
        {
            set { _CodeTesterDbT = value; }
            get => _CodeTesterDbT;
        }


        public double SampleWbt
        {
            set { _CodeTesterWbt = value; }
            get => _CodeTesterWbt;
        }
        public double NozzlePress { get => _NozzlePress; }
        public double AtmosphericPress { get => _AtmosphericPress; }
        public double StaticPress { get => _StaticPress; }
        public double CoolingCapacity
        {
            get => ComputeCoolingCapacity();
        }

        public double CoolingCapacityAverage { set; get; }

        public double CoolingCapacityMedian { set; get; }


        public static bool SelecX = true;

        public double EER => CoolingCapacity / Power;


        /// <summary>
        /// // Calculation according to ISO 5151 2017
        /// </summary>
        /// <returns></returns>


        //Vn is the specific volume of the dry air at Nozzle 
        // Vn = R * T /P   General gas low 
        // Vn = 0.78 at T= 273.7 , P = 1 atmospheric .
        // Vn = 0.78 * (1+ Dbt/273.15)* (101,325/(Patom +Pstatic))   where 101325 is the Normal Atmospheric pressure , P is the atmospheric pressure measured in pascal

        public double Vn(double Tdry, double press)
        {
            double Res = 0.78 * (1 + Tdry / 273.15) * 101324 / press;
            return Res;
        }


        //Vda Specific Volume of Moist air 
        // according to https://www.engineeringtoolbox.com/moist-air-specific-volume-d_25.html
        //vda =  Ra T / pa   or  = Ra T /( p - pw)   
        //Ra=287J/Kg.K

        double Vda(double Tdry, double Twet, double p)
        {
            return 287 * (Tdry + 273.15) / (p - Pw(Tdry, Twet, p));
        }

        //humdity ratio 
        public double MixingRatio(double Tdry, double Twet, double Press)
        {
            var e = Pw(Tdry, Twet, Press);

            return 0.6219907 * e / (Press - e);
        }


        // Wn is the Specific Humidity 
        //Press is the absolute pressure (parometeric pressure )

        public double Wn(double Tdry, double Twet, double Press)
        {

            double res = MixingRatio(Tdry, Twet, Press);

            return res;
        }

        //Vn_ is calculated is calculed according to equation B.7
        public double Vn_(double Tdry, double Twet, double Press)
        {

            return Vn(Tdry, Press) / (1 + Wn(Tdry, Twet, Press));

        }

        // Expansion Factor Y = 0.452+0.548 * alpha equatiob B.4 page 40 


        double Y(double NozzlePress, double AbsPressure)
        {
            double res = 0.452 + 0.548 * (1 - NozzlePress / AbsPressure);
            return res;
        }


        //Nozzle Discharge Coeffecient  Cd = 0.9986 - 7.006 / sqt(Re) +134.6/Re   Equation B.1  
        //Where Re is 

        public double Cd(double diameter, double Tdry)
        {
            double res = ReynoldNo(diameter, Tdry);
            //  return 0.013 * Math.Log(res, Math.E) + 0.82732;
            return (0.9986 - (7.006 / Math.Sqrt(res)) + 134.6 / res);//B.1 equatuin Iso 5151:2010

        }


        public double MassAirFlow()
        {
            double m = 0;
            var _Y = Y(NozzlePress, AtmosphericPress + StaticPress);
            //foreach (var noz in Program.Chamber.Sample.Nozzles)
            //{

            //    var _Cd = Cd(noz.Diameter, CodeTesterDbT);

            //    m += noz.Enabled
            //        ? _Y * _Cd * noz.Area * Math.Sqrt(2 * NozzlePress / Vn_(CodeTesterDbT, CodeTesterWbt, AtmosphericPress + StaticPress)) : 0;//- NozzlePress
            //}

            return m;
        }

        // Volumetic Air Flow  according to B.6
        public double AirFlowRate  // m^3/h
        {
            get
            {

                double m = 0;
                var _Y = Y(NozzlePress, AtmosphericPress + StaticPress);
                foreach (var noz in Program.Chamber.Sample.Nozzles)
                {
                    var _Cd = Cd(noz.Diameter, SampleDbT);
                    m += noz.Enabled
                        ? _Y * _Cd * noz.Area * Math.Sqrt(2 * NozzlePress * Vn_(SampleDbT, SampleWbt, AtmosphericPress + StaticPress - NozzlePress)) : 0;//- NozzlePress
                }


                var _vda = Vda(SampleDbT, SampleWbt, AtmosphericPress + StaticPress - NozzlePress);//- NozzlePress
                return m * 3600 / (1.204 * _vda);
            }
        }







        //public double MassAirFlow()
        //{
        //    double m = 0;

        //    foreach (var noz in Program.Chamber.Sample.Nozzles)
        //    {
        //        double Vn = SpecificVolume(CodeTesterDbT, CodeTesterWbt, AtmosphericPress - StaticPress);

        //        double cdd = Cd(noz.Diameter, CodeTesterDbT);
        //        m += noz.Enabled ? (Cd(noz.Diameter, CodeTesterDbT) * noz.Area * AirSpeed()) /
        //                           SpecificVolume(CodeTesterDbT, CodeTesterWbt, AtmosphericPress - NozzlePress + StaticPress) : 0;


        //    }

        //    return m;
        //}


        public double Ew_Corr()
        {
            _ew_corr = 0.000644 * (AtmosphericPress + StaticPress) * (SampleDbT - SampleWbt);
            return _ew_corr;

        }

        public double Pws(double Tdry)//IN PA
        {

            return 611.6411 * Math.Pow(10, 7.591386 * Tdry / (Tdry + 240.7263));//===> Equation 6 page 5


            // return    610.6 * Math.Exp(((17.2694 * Tdry) / (237.3 + Tdry)));
        }

        public double Pw(double Tdry, double Twet, double Press)
        {
            double Pw = Pws(Twet) - Press * 0.000662 * (Tdry - Twet);
            return Pw;//return Math.Abs(Pw); 
        }





        public double Enthalpy(double Tdry, double Twet, double Press)
        {
            double X = 0;
            if (SelecX)
            {
                X = MixingRatio(Tdry, Twet, Press);
                return (1.005 * Tdry + X * (2501 + 1.88 * Tdry));
            }

            else
            {
                X = AbsHum(Tdry, Twet, Press);
                return ((1.005 * Tdry + X * (2499.5 + 2.005 * Tdry)) / (1 + X));
            }

            //

        }

        public double AbsHum(double Tdry, double Twet, double Press)
        {
            var e = Pw(Tdry, Twet, Press);
            double res = 2.165 * e / (Tdry + 273.16);
            return res;

        }

        public double SpecificVolume(double Tdry, double Twet, double Press)
        {
            double X = 0;
            if (SelecX) X = MixingRatio(Tdry, Twet, Press);
            else X = AbsHum(Tdry, Twet, Press);

            return ((370.95 * (0.7724 + 1.244 * X) * (273.15 + Tdry)) / ((1 + X) * Press));
        }

        //public double AirDensity()
        //{
        //    _airDensity = (1 + _absHum) * (AtmosphericPress + StaticPress) /
        //         (370.95 * (0.7724 + 1.244 * _absHum) * (273.15 + CodeTesterDbT));
        //    return _airDensity;
        //}

        public double AirSpeed()
        {
            double Vn = SpecificVolume(SampleDbT, SampleWbt, AtmosphericPress + StaticPress);
            //  double res = Math.Sqrt(2 * Math.Abs(NozzlePress)* Vn);//
            double res = Math.Sqrt(2 * Math.Abs(NozzlePress));
            return res;

        }



        //Re based on B.1 equation 
        //Re = Velocity  * Dn / Kinematic  Vescousity 
        public double ReynoldNo(double diameter, double Tdry) => (-0.3955 * Tdry + 80.7707) * AirSpeed() * diameter;





        //public double MassAirFlow()// equation B.3
        //{
        //    double m = 0;
        //    double a = 1 - (NozzlePress / (AtmosphericPress - StaticPress));
        //    double y = 0.452 + 0.548 * a;
        //    double Wn = MixingRatio(CodeTesterDbT, CodeTesterWbt, AtmosphericPress + StaticPress);
        //    double Sv = SpecificVolume(CodeTesterDbT, CodeTesterWbt, AtmosphericPress + StaticPress);
        //    double Svn = Sv / (1 + Wn);
        //    double V = Math.Sqrt(2 * Math.Abs(NozzlePress) / Svn);
        //    foreach (var noz in Program.Chamber.Sample.Nozzles)
        //    {
        //        var cd = Cd(noz.Diameter, CodeTesterDbT);
        //        m += noz.Enabled ? y * cd * noz.Area * V : 0;


        //    }

        //    return m;
        //}



        //public double AirFlowRate  // m^3/h
        //{
        //    get
        //    {
        //        double m = 0;
        //        foreach (var noz in Program.Chamber.Sample.Nozzles)
        //        {
        //            double Vn = SpecificVolume(CodeTesterDbT, CodeTesterWbt, AtmosphericPress - StaticPress);
        //           m += Cd(noz.Diameter, CodeTesterDbT) * (noz.Enabled? noz.Area * AirSpeed()* Math.Sqrt(Vn) : 0);
        //          //  m += Cd(noz.Diameter, CodeTesterDbT) * (noz.Enabled ? noz.Area * AirSpeed() : 0);
        //        }
        //        return m * 3600 ;
        //    }
        //}

        //public double UnCorrCoolingCapacity()
        //{
        //    try
        //    {
        //        //CodeTesterDbT = 15.5;
        //        var ma = MassAirFlow();
        //        _coolingCapacity = ma * (Enthalpy(InDoorDbt, InDoorWbt, AtmosphericPress + StaticPress) -
        //                                 Enthalpy(CodeTesterDbT, CodeTesterWbt, AtmosphericPress + StaticPress));
        //        _coolingCapacity *= 3.412 * 1000;

        //        return _coolingCapacity; //debug
        //    }
        //    catch (Exception ex)
        //    {
        //        LoggerFile.WriteException(ex);
        //    }

        //    return 0;
        //}

        double Altitude(double Pressure)
        {

            return 44332.136 * (1 - Math.Pow(Pressure / 101325, 0.1798885));
        }
        public double ComputeCoolingCapacity()
        {
            try
            {
                var flowRare = AirFlowRate * 1000 / 3600;
                var Altitureindoor = Altitude(AtmosphericPress);
                var AltitureCodeTester = Altitude(AtmosphericPress - Math.Abs(NozzlePress));
                //PsychrometricPointSI PsychInDoor = new PsychrometricPointSI(Altitureindoor);
                //PsychrometricPointSI PsychCodeTester = new PsychrometricPointSI(AltitureCodeTester, flowRare);
                //PsychrometricPointSI PsychCodeTester1 = new PsychrometricPointSI(Altitureindoor, flowRare);
                //   PsychCodeTester.CalcAllUsingDbWb(CodeTesterDbT, CodeTesterWbt);
                //   PsychCodeTester1.CalcAllUsingDbWb(CodeTesterDbT, CodeTesterWbt);
                //   PsychInDoor.CalcAllUsingDbWb(InDoorDbt, InDoorWbt);
                //   var ma = MassAirFlow();
                //   var ma1 = PsychCodeTester.MassicFlowKilogramsPerSecond *3600/1000;
                ////   _coolingCapacity = ma * (PsychInDoor.Enthalpy - PsychCodeTester.Enthalpy);
                // _coolingCapacity = ma * (PsychInDoor.Enthalpy - PsychCodeTester1.Enthalpy);
                // Enthalpy(CodeTesterDbT, CodeTesterWbt, AtmosphericPress - NozzlePress - StaticPress));

                //_coolingCapacity = ma * (Enthalpy(InDoorDbt, InDoorWbt, AtmosphericPress + StaticPress) -
                //                       Enthalpy(CodeTesterDbT, CodeTesterWbt, AtmosphericPress + StaticPress));// Enthalpy(CodeTesterDbT, CodeTesterWbt, AtmosphericPress - NozzlePress - StaticPress));



                //_coolingCapacity *= 3.412 * 1000;

                return _coolingCapacity * 3.412 * 1000;//+ Program.Chamber.CoolCapacityCalibration.Calibrate(InDoorDbt - CodeTesterDbT)  ; //debug
            }
            catch (Exception ex)
            {
                LoggerFile.WriteException(ex);
            }

            return 0;
        }




        public void Read()
        {
            //  SelecX = false; 
            _Time = DateTime.Now;
            //_InDoorDbt = Program.Chamber.InDoorAhu.DBTempAnCh.CalibFilteredValue; //Program.Chamber.InDoorAhu.DbtReadingFilter.Average();
            //_InDoorHum = Program.Chamber.InDoorAhu.HUMAnCh.CalibFilteredValue;
            //_InDoorWbt = Program.Chamber.InDoorAhu.WBTempAnCh.CalibFilteredValue;//Program.Chamber.InDoorAhu.WbtReadingFilter.Average();
            //_OutDoorDbt = Program.Chamber.OutDoorAhu.DBTempAnCh.CalibFilteredValue;//.DBTempAnCh.CalibFilteredValue;///Program.Chamber.OutDoorAhu.DbtReadingFilter.Average();
            //_OutDoorHum = Program.Chamber.OutDoorAhu.HUMAnCh.CalibFilteredValue;
            //_OutDoorWbt = Program.Chamber.OutDoorAhu.WBTempAnCh.CalibFilteredValue;//Program.Chamber.OutDoorAhu.WbtReadingFilter.Average();
            _Voltage = Program.Chamber.Sample.Voltage;
            _Current = Program.Chamber.Sample.Current;
            _Power = Program.Chamber.Sample.Power;
            _Frequency = Program.Chamber.Sample.Frequency;
            _PowerFactor = Program.Chamber.Sample.Powerfactor;
            _CodeTesterDbT = Program.Chamber.CodeTester.DBTempAnCh.CalibFilteredValue;//Program.Chamber.CodeTester.DbtFilter.Average();
            _CodeTesterWbt = Program.Chamber.CodeTester.WBTempAnCh.CalibFilteredValue;//Program.Chamber.CodeTester.WbtFilter.Average();
            _AtmosphericPress = Program.Chamber.Sample.AtmosphericPress;
            _NozzlePress = Program.Chamber.Sample.NozzlePress;
            _StaticPress = Program.Chamber.Sample.StaticPress;


        }


        public void Calculate()
        {
            Read(); // read all sensors 
            _eCodeTester = Pws(SampleDbT);



        }
    }


}
