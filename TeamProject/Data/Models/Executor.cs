using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamProject.Data.Models
{
    public class Executor
    {
        public int id_User { get; set; }
        public virtual User user { get; set; }
        public List<Technic> executorOf { get; set; }
    }
}
