using Prueba_Project.Models;
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
        public ActionResult Index()
        {
            var model = new GreetingsViewModel();
            model.Message = ConfigurationManager.AppSettings["message"];
            model.prueba = "hello";
            return View(model);
        }
    }
}