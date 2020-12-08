using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamProject.Data.Models;

namespace TeamProject.Data.interfaces
{
    public interface IExecutor
    {
        IEnumerable<Executor> AllExecutors { get; }
        Executor FindObjectExecutor(string userName);
    }
}
