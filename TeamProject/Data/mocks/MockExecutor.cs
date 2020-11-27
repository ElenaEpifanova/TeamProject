using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamProject.Data.interfaces;
using TeamProject.Data.Models;

namespace TeamProject.Data.mocks
{
    public class MockExecutor: IExecutor
    {
        private readonly IUser _user = new MockUser();
        public IEnumerable<Executor> AllExecutors
        {
            get
            {
                return new List<Executor>
                {
                    new Executor { id_User = 1, user = _user.AllUsers.First()},
                    new Executor { id_User = 2, user = _user.AllUsers.Last()}
                };

            }

        }
    }
}
