using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using Microsoft.Ajax.Utilities;
using ReactWebApp.Models;

namespace ReactWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //return View();
            return RedirectToAction("Test", "Home");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        private List<Client> GenerateClients()
        {
            List<Client> clients = new List<Client>();
            List<Thing> buffer = new List<Thing>();
            buffer.Add(new Thing
            {
                Title = "cigarettes",
                Count = 20
            });
            buffer.Add(new Thing
            {
                Title = "lighter",
                Count = 2
            });
            buffer.Add(new Thing
            {
                Title = "vodka",
                Count = 4
            });
            clients.Add(new Client
            {
                Age = 78,
                Name = "Boozer",
                Things = buffer
            });

            buffer.Clear();
            buffer.Add(new Thing
            {
                Title = "smoothie",
                Count = 700
            });
            buffer.Add(new Thing
            {
                Title = "fruit",
                Count = 100500
            });
            clients.Add(new Client
            {
                Age = 20,
                Name = "Healthy Vasyan",
                Things = buffer
            });
            return clients;
        }

        /*
         Вывод вьюшки с компонентом
         вьюшка - ~/Views/Home/Test
         Компонент - ~/Content/js/ClientsTutorial.jsx
         */
        public ActionResult Test()
        {
            return View();
        }

        // отдача модели в виде JSON
        [OutputCache(Location = OutputCacheLocation.None)]
        public ActionResult GetThings()
        {
            //var clients = GenerateClients();

            var list = new List<Thing> { 
                new Thing
                {
                    Title = "smoothie",
                    Count = 700
                },
                new Thing
                {
                    Title = "fruit",
                    Count = 100500
                }
            };
            //обязательно с AllowGet, по умолчанию .NET не дает JSON просто так
            return Json(list, JsonRequestBehavior.AllowGet); 
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}