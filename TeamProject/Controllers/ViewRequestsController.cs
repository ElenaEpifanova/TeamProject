using Microsoft.AspNetCore.Mvc;
using TeamProject.Data.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamProject.ViewModels;

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

        public ViewResult List()
        {
            ViewRequestsViewModel obj = new ViewRequestsViewModel();
            obj.AllRequests = _allRequests.AllRequests;
            obj.AllShops = _allShops.AllShops;
            obj.AllUsers = _allUsers.AllUsers;

            return View(obj);
        }


    }
}
