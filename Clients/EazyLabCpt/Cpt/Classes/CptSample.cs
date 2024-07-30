using EazyLab.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EazyLab.Cpt.Classes
{
    public class CptSample : Entity
    {
        public CptProfile Profile { get; set; }
        public CptModel Model { get; set; }
        public string SerialNo { set; get; }
    }
}
