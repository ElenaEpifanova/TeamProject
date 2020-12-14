using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamProject.Data.Models
{
    public class Technic
    {
        public Technic()
        {
            TypeTechnic = new TypeTechnic();
            executor = new Executor();
            request = new Request();
        }
        public int Id {set; get;}
        public int TypeTechnicId { set; get; }
        public virtual TypeTechnic TypeTechnic { set; get; }
      
        public int delay { set; get; }  //type time
        public int duration { set; get; } //type time
        public string path { set; get; }

        public int ExecutorId { set; get; }
        public virtual Executor executor { set; get; }



        public int quantity { set; get; }

        public int RequestId { set; get; }

        public virtual Request request { set; get; }

    }
}
