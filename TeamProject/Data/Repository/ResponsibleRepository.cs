using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using TeamProject.Data.interfaces;
using TeamProject.Data.Models;

namespace TeamProject.Data.Repository
{
    public class ResponsibleRepository : IResponsible
    {
        private readonly AppDBContent appDBContent;
        public ResponsibleRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Responsible> AllResponsibles => appDBContent.Responsible.Include(r => r.User);
    }
}
