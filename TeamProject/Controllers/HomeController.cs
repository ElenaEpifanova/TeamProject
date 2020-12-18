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
using System.Text;
using System.IO;

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
            HomeViewModel obj = new HomeViewModel();
            obj.AllRequests = _allRequests.AllRequests;
            //--Получение объекта
            object request;
            TempData.TryGetValue("request", out request);
            request = JsonConvert.DeserializeObject<Request>((string)request);
            obj.request = request as Request;
            TempData.Remove("request");
            string str = SctiptGraphic(obj.request);
            Graphic(str);
            TempData["request"] = JsonConvert.SerializeObject(request, Formatting.None,
                     new JsonSerializerSettings()
                     {
                         ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                     });
            return View("SupplyRequest", obj);
            //--End
        }

        [HttpGet]
        public IActionResult View(int id)
        {
            HomeViewModel obj = new HomeViewModel();
            obj.AllRequests = _allRequests.AllRequests;
            obj.request = _allRequests.AllRequests.FirstOrDefault(i => i.Id == id);
            string str = SctiptGraphic(obj.request);
            Graphic(str);
            return View("ViewRequest", obj);
        }
        [HttpPost]
        public IActionResult Supply(HomeViewModel obj, int id)
        {
            object request;
            TempData.TryGetValue("request", out request);
            request = JsonConvert.DeserializeObject<Request>((string)request);
            obj.request = request as Request;
            TempData.Remove("request");
            if (id == 1)
            {
                /*TempData["request"] = JsonConvert.SerializeObject(request, Formatting.None,
                     new JsonSerializerSettings()
                     {
                         ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                     });*/
                return RedirectToAction("Index", "Section1"); // отсылочка к редактуре 1
            }
            if (id == 2)
            {
                /*TempData["request"] = JsonConvert.SerializeObject(request, Formatting.None,
                     new JsonSerializerSettings()
                     {
                         ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                     });*/
                return RedirectToAction("Index", "Section2"); // отсылочка к редактуре 2
            }
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
            
        public string SctiptGraphic(Request request)
        {
            string str = "var items = new vis.DataSet({type: { start: 'ISODate', end: 'ISODate' }});\nvar groups = new vis.DataSet\n([\n{id: 'bar',\ncontent: 'График',subgroupStack: { sg_1: true},\nsubgroupVisibility: { sg_1: true}}\n]);";
            DateTime b, e;
            for (int i = 0; i < request.technic.Count(); i++)
            {
                b = request.begin;
                int delay = request.technic[i].delay;
                b = GetDateTime(b, delay);
                delay = request.technic[i].duration;
                e = GetDateTime(b, delay);

                str += "\nitems.add(\n[{id: ";
                str += (i + 1).ToString();
                str += ",\ncontent: '";
                str += request.technic[i].TypeTechnic.name;
                str += "',\nstart: '";
                str += DateToString(b);
                str += "' ,\nend: '";
                str += DateToString(e);
                str += "',\ngroup: 'bar',\nsubgroup: 'sg_1',\nsubgroupOrder: 0 },\n]);";
            }
            str += "\nvar container = document.getElementById('visualization'); \nvar options = { \nstart:'";
            b = request.begin;
            b = b.AddDays(-1);
            e = request.end;
            e = e.AddDays(+1);
            str += DateToString(b).Substring(0, 10) + "',\nend:'" + DateToString(e).Substring(0, 10) + "' ,\n};";
            str += "\nvar timeline = new vis.Timeline(container, items, groups, options); ";
            return str;
        }

        static DateTime GetDateTime (DateTime data, int delay)
        {
            if (delay > 24)
            {
                data = data.AddDays(delay / 24);
                delay %= 24;
            }
            data = data.AddMinutes(delay * 30);
            if (data.Hour < 8 || data.Hour > 20)
                data = data.AddHours(12);
            return data;
        }

        static string DateToString(DateTime b)
        {
            string tb = b.Year.ToString();
            tb += '-';
            if (b.Month < 10)
                tb += '0' + b.Month.ToString();
            else
                tb += b.Month.ToString();
            tb += '-';
            if (b.Day < 10)
                tb += '0' + b.Day.ToString();
            else
                tb += @b.Day.ToString();
            tb += 'T';

            if (b.Hour < 10)
                tb += '0' + b.Hour.ToString();
            else
                tb += b.Hour.ToString();
            tb += ':';
            if (b.Minute < 10)
                tb += '0' + b.Minute.ToString();
            else
                tb += b.Minute.ToString();
            tb += ':';
            if (b.Second < 10)
                tb += '0' + b.Second.ToString();
            else
                tb += b.Second.ToString();
            return tb;
        }

        static void Graphic(string str)
        {
            FileStream file1 = new FileStream("wwwroot\\js\\graphic.js", FileMode.Create); //создаем файловый поток
            StreamWriter writer = new StreamWriter(file1); //создаем «потоковый писатель» и связываем его с файловым потоком
            writer.Write(str); //записываем в файл
            writer.Close(); //закрываем поток. Не закрыв поток, в файл ничего не запишется
        }
    }
}
