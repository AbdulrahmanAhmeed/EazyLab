using EazyLab.Model;
using LiteDB;
using SuperSimpleTcp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EazyLab.Cpt.Classes
{
    public class CptSample : Entity
    {
        public List<CptProfile> Profiles { get; set; }
        public CptModel Model { get; set; }
        public string SerialNo { set; get; }
        [BsonIgnore]
        public CptProfile.ProfileSource SelectedSource { get; set; }
    }
}
