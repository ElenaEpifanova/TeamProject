using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamProject.Data.Models;

namespace TeamProject.Data.interfaces
{
    interface ITechnic
    {
        IEnumerable<Technic> Technics { get; }
        Technic getObjectTechnic(int technicId);
    }
}
