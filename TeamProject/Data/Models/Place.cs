using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamProject.Data.Models
{
    public class Place
    {
        public int id { set; get; }
        public string name { set; get; }
        public List<Request> requests { set; get; }
    }
}
