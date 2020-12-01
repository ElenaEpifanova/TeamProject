using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamProject.Data.interfaces;
using TeamProject.Data.Models;

namespace TeamProject.Data.Repository
{
    public class UserRepository : IUser
    {
        private readonly AppDBContent appDBContent;
        public UserRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<User> AllUsers => appDBContent.User;

        public User getObjectUser(int userId) => appDBContent.User.FirstOrDefault(p => p.Id == userId);
    }
}
