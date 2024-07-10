using EazyLab.Equipments.Equipments;
using EazyLab.Modbus;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitsNet;
namespace EazyLab.Client.Classes
{
    public class PressSensor 
    {
        UnitsNet.Units.PressureUnit baseUnit = UnitsNet.Units.PressureUnit.Bar;
        UnitsNet.Units.PressureUnit BaseUnit { get => baseUnit; set => baseUnit = value; }//
        UnitsNet.Units.PressureUnit Unit { set; get; }


        public  virtual double Read()
        {
            return 0; 
        }

        public enum PressSensorRegisters
        {
            Pressure_Unit = 0,
            Pressure = 1,
        }
        PressSensorRegisters Press_Registers;
    }
}
