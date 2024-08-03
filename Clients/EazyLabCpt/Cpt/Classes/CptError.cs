using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EazyLab.Cpt.Classes
{
    public class CptError
    {
        public enum ErrorState { noError , upperLimit,lowerLimit}

        public ErrorState Temp1 { get; set; } = ErrorState.noError;
        public ErrorState Temp2 { get; set; } = ErrorState.noError;
        public ErrorState Temp3 { get; set; } = ErrorState.noError;
        public ErrorState Temp4 { get; set; } = ErrorState.noError;
        public ErrorState Temp5 { get; set; } = ErrorState.noError;
        public ErrorState Temp6 { get; set; } = ErrorState.noError;
        public ErrorState Voltage { get; set; } = ErrorState.noError;
        public ErrorState Current { get; set; } = ErrorState.noError;
        public ErrorState Power { get; set; } = ErrorState.noError;
        public ErrorState Energy { get; set; } = ErrorState.noError;

    }
}
