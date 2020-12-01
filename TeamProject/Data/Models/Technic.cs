using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamProject.Data.Models
{
    public class Technic
    {
        public int Id {set; get;}
        public int TypeTechnicId { set; get; }
        public virtual TypeTechnic TypeTechnic { set; get; }
      
        public DateTime delay { set; get; }  //type time
        public DateTime duration { set; get; } //type time
        public string path { set; get; }

        public int ExecutorId { set; get; }
        public virtual Executor Executor { set; get; }



        public int quantity { set; get; }

        public int RequestId { set; get; }

        public virtual Request Request { set; get; }

    }
}
