using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using TeamProject.Data.interfaces;
using TeamProject.Data.Models;

namespace TeamProject.Data.Repository
{ 
    public class ExecutorRepository: IExecutor
    {
        private readonly AppDBContent appDBContent;

        public ExecutorRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Executor> AllExecutors => appDBContent.Executor.OrderBy(e => e.User.name);

        public Executor FindObjectExecutor(string userName)
        {
            int idUser = appDBContent.User.First(u => u.name == userName).Id;
            return appDBContent.Executor.First(e => e.UserId == idUser);
        }
    }




}
