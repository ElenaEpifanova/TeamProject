﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamProject.Data.Models
{
    public class Technic
    {
        public int id {set; get;}
        public int id_type { set; get; }
        public virtual TypeTechnic type { set; get; }
      
        public DateTime delay { set; get; }  //type time
        public DateTime duration { set; get; } //type time
        public string path { set; get; }

        public virtual Executor executor { set; get; }

        public int id_executor { set; get; }

        public int quantity { set; get; }

        public int id_request { set; get; }

        public virtual Request request { set; get; }

    }
}
