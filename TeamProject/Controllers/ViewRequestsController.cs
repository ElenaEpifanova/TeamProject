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

        public ViewRequestsController(IRequest iAllRequests, IShop iAllShops, IResponsible iAllResponsibles)
        {
            _allRequests = iAllRequests;
        }

        public ViewResult Index()
        {
            ViewRequestsViewModel obj = new ViewRequestsViewModel();
            obj.AllRequests = _allRequests.AllRequests;

            return View(obj);
        }

        public ViewResult ViewRequest()
        {
            ViewRequestsViewModel obj = new ViewRequestsViewModel();
            obj.AllRequests = _allRequests.AllRequests;

            return View(obj);
        }

        public RedirectToActionResult ViewRequest(int id)
        {
            var item = _allRequests.AllRequests.FirstOrDefault(i => i.Id == id);
            return RedirectToAction("ViewRequest");
        }
    }
}
