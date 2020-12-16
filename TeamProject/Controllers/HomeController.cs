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
    public class HomeController : Controller
    {
        private readonly IRequest _allRequests;
        private readonly AddRequest _addRequest;

        public HomeController(IRequest iAllRequests /*AddRequest addRequest*/)
        {
            _allRequests = iAllRequests;
            //_addRequest = addRequest;
        }

        public ViewResult Index()
        {
            HomeViewModel obj = new HomeViewModel();
            obj.AllRequests = _allRequests.AllRequests;
            return View(obj);
        }

        public ViewResult Supply()
        {
            try
            {
                HomeViewModel obj = new HomeViewModel();
                obj.AllRequests = _allRequests.AllRequests;
                //--Получение объекта
                object request;
                TempData.TryGetValue("request", out request);
                request = JsonConvert.DeserializeObject<Request>((string)request);
                obj.request = request as Request;
                TempData["request"] = JsonConvert.SerializeObject(request, Formatting.None,
                     new JsonSerializerSettings()
                     {
                         ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                     });
                return View("SupplyRequest", obj);
            }
            catch (Exception)
            {
                return View("Index", "Section2");
            }
            //--End
        }
        
        [HttpGet]
        public IActionResult View1(int id)
        {
            HomeViewModel obj = new HomeViewModel();
            obj.AllRequests = _allRequests.AllRequests;
            obj.request = _allRequests.AllRequests.FirstOrDefault(i => i.Id == id);
            return View("ViewRequest", obj);
        }
        [HttpPost]
        public IActionResult Supply(HomeViewModel obj, int id)
        {
            object request;
            TempData.TryGetValue("request", out request);
            request = JsonConvert.DeserializeObject<Request>((string)request);
            obj.request = request as Request;
            obj.AllRequests = _allRequests.AllRequests;
            if (id == 1)
                return RedirectToAction("Index", "Section1"); // отсылочка к редактуре 1
            if (id == 2)
                return RedirectToAction("Index", "Section2"); // отсылочка к редактуре 2
            else
            {
                //_addRequest.Add_Request(1, 1, new DateTime(2000, 12, 12), new DateTime(2000, 12, 12), "12", "12", 1);
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
