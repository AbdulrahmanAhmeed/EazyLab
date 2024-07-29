using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EazyLab.Cpt.Classes
{
    public class SampleReadyEventArgs : EventArgs
    {
        public CptSample cptSample {  get; set; } 
    }
}
