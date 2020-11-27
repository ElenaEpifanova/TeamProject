﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamProject.Data.Models;

namespace TeamProject.Data.interfaces
{
    interface IResponsible
    {
        IEnumerable<Responsible> AllResponsibles { get; }
    }
}
