using Microsoft.AspNetCore.Mvc;
using TeamProject.Data.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamProject.ViewModels;
using TeamProject.Data.Models;
using Newtonsoft.Json;
using TeamProject.Data;

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

        public ViewResult Supply()
        {
            ViewRequestsViewModel obj = new ViewRequestsViewModel();
            obj.AllRequests = _allRequests.AllRequests;
            //--Получение объекта
            object request;
            TempData.TryGetValue("request", out request);
            request = JsonConvert.DeserializeObject<Request>((string)request);
            obj.request = request as Request;
            //--End
            return View("SupplyRequest", obj);
        }

        [HttpGet]
        public IActionResult View1(int id)
        {
            ViewRequestsViewModel obj = new ViewRequestsViewModel();
            obj.AllRequests = _allRequests.AllRequests;
            obj.request = _allRequests.AllRequests.FirstOrDefault(i => i.Id == id);
            return View("ViewRequest", obj);
        }
        public IActionResult View2(int id)
        {
            ViewRequestsViewModel obj = new ViewRequestsViewModel();

            TempData["request"] = JsonConvert.SerializeObject(obj.request, Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
            if (id == 1)
                return RedirectToAction("Index", "Section1");
            else
                return RedirectToAction("Index", "Section2");
        }
    }
}
