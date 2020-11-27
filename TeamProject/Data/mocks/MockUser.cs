using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamProject.Data.interfaces;
using TeamProject.Data.Models;

namespace TeamProject.Data.mocks
{
    public class MockUser: IUser
    {
        public IEnumerable<User> AllUsers
        {
            get
            {
                return new List<User>
                { 
                    new User {name = "Дубинин М.Р."},
                    new User {name = "Кулагин П.Б."},
                    new User {name = "Коротаев М.Я."}
                };

            }

        }

        public User getObjectUser(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
