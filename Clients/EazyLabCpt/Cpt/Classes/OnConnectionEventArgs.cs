
using System;

namespace EazyLab.Cpt.Classes
{
    public class OnConnectionEventArgs : EventArgs
    {
        public string SerialNo { get; set; }
        public bool Connected { get; set; }



    }
}
