using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using EazyLabClient;

namespace EazyLab.Classes
{
    public  class DbBase
    {
        //public const string IncludeString = "";
        public static LiteRepository db = Program.LiteRepository;
       // public virtual string IncludeExpression { set; get; } 
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
        public DateTime CreatedDate { get; set; }


       
    }
}
