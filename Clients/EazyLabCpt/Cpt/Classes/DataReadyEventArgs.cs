using Modbus;

using System;

namespace EazyLab.Cpt.Classes
{
    public  class DataReadyEventArgs :EventArgs
    {
        public string SerialNo { get; set; }
        public Result Result { get; set; }
        public CptDataPacketVer1 DataPacket { get; set; }
        

    }
}
