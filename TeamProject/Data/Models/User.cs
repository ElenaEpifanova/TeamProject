﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamProject.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string name { get; set; }
        public virtual List<Responsible> responsibles { get; set; }
        public virtual List<Executor> executors { get; set; }
    }
}
