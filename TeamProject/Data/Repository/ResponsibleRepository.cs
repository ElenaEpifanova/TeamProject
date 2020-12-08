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

        public IEnumerable<Responsible> AllResponsibles => appDBContent.Responsible.OrderBy(r => r.User.name);

        public Responsible FindObjectResponsible(string userName)
        {
            int idUser = appDBContent.User.First(u => u.name == userName).Id;
            return appDBContent.Responsible.First(r => r.UserId == idUser);
        }
    }
}
