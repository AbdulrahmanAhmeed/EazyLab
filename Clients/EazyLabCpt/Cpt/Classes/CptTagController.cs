using EazyLab.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EazyLab.Cpt.Classes
{
    public class CptTagController : Entity
    {
        public int RGB { get; set; }
        public double Max { get; set; }
        public double Min { get; set; }    
    }
}
