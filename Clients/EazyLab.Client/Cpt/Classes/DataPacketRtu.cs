using EazyLab;
using EazyLabClient;
using EazyLabClient.Classes;
using System;
using System.Collections.Generic;

namespace Client.Classes
{
    [Serializable]
    public class RtuDataPacket

    {
        private DateTime _Time;
        private double _Dbt;
        private double _Hum;
        private double _Voltage;
        private double _Current;
        private double _Power;
        private double _energy;
        private double _Frequency;
        private double _PowerFactor;
        public DateTime Time => _Time;
        public double DbTemp { get => _Dbt; }
        public double Hum { get => Program.Chamber.Ahu.Humidity(); }
        public double Voltage
        {
            get => _Voltage;
            set => _Voltage = value;
        }
        public double Current { get => _Current; }
        public double Power { get => _Power; }
        public double Energy { get => _energy; }
        public double PowerFactor { get => _PowerFactor; }
        public double Frequency
        {
            get => _Frequency;

        }

        private  List<double> _Temp = new List<double>();


        public double Temp1 => _Temp[0];
        public double Temp2 => _Temp[1];
        public double Temp3 => _Temp[2];
        public double Temp4 => _Temp[3];
        public double Temp5 => _Temp[4];
        public double FreezerAve => (_Temp[0] + _Temp[1] + _Temp[2] + _Temp[3]) / 4;
        public double Temp6 => _Temp[5];
        public double Temp7 => _Temp[6];
        public double Temp8 => _Temp[7];
        public double Temp9 => _Temp[8];
        public double Temp10 => _Temp[9];
        public double Temp11 => _Temp[10];
        public double Temp12 => _Temp[11];
        public double Temp13 => _Temp[12];
        public double Temp14 => _Temp[13];
        public double Temp15 => _Temp[14];
        public double Temp16 => _Temp[15];



        // public List<double>  Temp => _Temp; 

        public void Read(SamplePosition samplePosition)
        {

            try
            {
                _Time = DateTime.Now;
                _Dbt = Program.Chamber.Ahu.Dbt;
                _Hum = Program.Chamber.Ahu.Hum;
                _Voltage = samplePosition.VoltCh.CalibFilteredValue;
                _Current = samplePosition.CurrentCh.CalibFilteredValue;
                _Power = samplePosition.PowerCh.CalibFilteredValue;
                _Frequency = samplePosition.FrequencyCh.CalibFilteredValue;
                _PowerFactor = samplePosition.PowerFactorCh.CalibFilteredValue;
                _Temp.Clear();
                for (int i = 0; i < samplePosition.TempChs.Count; i++)
                {
                    _Temp.Add(samplePosition.TempChs[i].CalibFilteredValue);
                    //MainformGlobals.Current_Temperature_Readings[i] = _Temp[i];
                }


            }
            catch (Exception ex)
            {

                LoggerFile.WriteException(ex);
            }

        }


    }


}
