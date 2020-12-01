using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamProject.Data.Models
{
    public class Responsible
    {
        public int id_user { get; set; }
        public virtual User user { get; set; }
        public List<Request> requests { get; set; }
    }
}
