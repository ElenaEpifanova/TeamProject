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

        public IEnumerable<Executor> AllExecutors => appDBContent.Executor;
    }




}
