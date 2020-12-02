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
        private readonly IResponsible _allResponsibles;

        public ViewRequestsController(IRequest iAllRequests, IShop iAllShops, IResponsible iAllResponsibles)
        {
            _allRequests = iAllRequests;
            _allShops = iAllShops;
            _allResponsibles = iAllResponsibles;
        }

        public ViewResult List()
        {
            ViewRequestsViewModel obj = new ViewRequestsViewModel();
            obj.AllRequests = _allRequests.AllRequests;
            obj.AllShops = _allShops.AllShops;
            obj.AllResponsibles = _allResponsibles.AllResponsibles;

            return View(obj);
        }


    }
}
