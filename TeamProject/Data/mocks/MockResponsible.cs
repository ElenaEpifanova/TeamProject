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
                    new Responsible { id_User = 2, user = _user.AllUsers.First()},
                    new Responsible { id_User = 3, user = _user.AllUsers.Last()}
                };
            }
        }
    }
}
