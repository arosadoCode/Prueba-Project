using Microsoft.Web.Infrastructure;
using Prueba_Project.Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prueba_Project.Controllers
{
    public class GreetingController : Controller
    {
        // GET: Greeting
        public ActionResult Index(string name)
        {
            var model = new GreetingsViewModel();
            model.Message = ConfigurationManager.AppSettings["message"];
            model.name = name ?? "no name";
            model.prueba = "hello";
            return View(model);
        }
    }
}