using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamProject.Data.interfaces;
using TeamProject.Data.Models;

namespace TeamProject.Data.Repository
{
    public class TechnicRepository : ITechnic
    {

        private readonly AppDBContent appDBContent;
        public TechnicRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }


        public IEnumerable<Technic> AllTechnics => appDBContent.Technic;

        public Technic getObjectTechnic(int technicId) => appDBContent.Technic.FirstOrDefault(t => t.Id == technicId);

    }
}
