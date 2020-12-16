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
        private readonly AddTechnic _addTechnic;

        public HomeController(IRequest iAllRequests, AddRequest addRequest, AddTechnic addTechnic)
        {
            _allRequests = iAllRequests;
            _addRequest = addRequest;
            _addTechnic = addTechnic;
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
            if (id == 1)
                return RedirectToAction("Index", "Section1"); // отсылочка к редактуре 1
            if (id == 2)
                return RedirectToAction("Index", "Section2"); // отсылочка к редактуре 2
            else
            {
                _addRequest.Add_Request(obj.request.ShopId, obj.request.ResponsibleId, obj.request.begin, obj.request.end, obj.request.description, obj.request.comment, obj.request.PlaceId);
                obj.AllRequests = _allRequests.AllRequests;

                int requestID = obj.AllRequests.Last().Id;

                for (int i = 0; i < obj.request.technic.Count; i++)
                {
                    Technic temp = obj.request.technic[i];
                    _addTechnic.Add_Technic(temp.TypeTechnicId, temp.quantity, temp.delay, temp.duration, temp.path, temp.ExecutorId, requestID);
                }

                return RedirectToAction("Index", "Home");
            }
        }
    }
}
