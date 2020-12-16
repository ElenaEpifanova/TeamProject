using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamProject.Data.Models;

namespace TeamProject.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable <Request> AllRequests { get; set; }
        public Request request { get; set; }

    }
}
