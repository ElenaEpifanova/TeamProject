using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamProject.Data.Models
{
    public class TypeTechnic
    {
        public int id { set; get; }
        public string name { set; get; }
        public int quantity { set; get; }
        public List<Technic> technics { set; get; }

    }
}
