using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamProject.Data.Models;

namespace TeamProject.Data.interfaces
{
    interface IUser
    {
        IEnumerable<User> AllUsers { get; }
        User getObjectUser(int userId);
    }
}
