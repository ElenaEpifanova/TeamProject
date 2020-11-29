using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamProject.Data.interfaces;

namespace TeamProject.Controllers
{
    public class ViewRequestsController : Controller
    {
        private readonly IRequest _allRequests;
        private readonly IShop _allShops;
        private readonly IUser _allUsers;

        public ViewRequestsController(IRequest iAllRequests, IShop iAllShops, IUser iAllUsers)
        {
            _allRequests = iAllRequests;
            _allShops = iAllShops;
            _allUsers = iAllUsers;
        }

        public ViewResult Index()
        {
            var Requests = _allRequests.Requests;

            return View(Requests);
        }


    }
}
