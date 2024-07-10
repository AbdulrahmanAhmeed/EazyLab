using EazyLab.Types;
using System;

namespace EazyLab.Cpt.Classes
{
    public  class DataReadyEventArgs :EventArgs
    {
        public string SerialNo { get; set; }
        public ModbusResult Result { get; set; }
        public CptDataPacketVer1 DataPacket { get; set; }
        

    }
}
