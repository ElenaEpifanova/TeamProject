using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamProject.Data.interfaces;
using TeamProject.Data.Models;

namespace TeamProject.Data.mocks
{
    public class MockResponsible : IResponsible
    {
        private readonly IUser _user = new MockUser();
        public IEnumerable<Responsible> AllResponsibles
        {
            get
            {
                return new List<Responsible>
                {
                    new Responsible { UserId = 2, User = _user.AllUsers.First()},
                    new Responsible { UserId = 3, User = _user.AllUsers.Last()}
                };
            }
        }
    }
}
