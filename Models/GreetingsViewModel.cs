using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Prueba_Project.Modelo;

namespace Prueba_Project.Modelo
{
    public class GreetingsViewModel
    {
        public string Message { get; set; }
        public string prueba { get; set; }
        public string name { get; set; }
        public IEnumerable<Restaurant> Restaurants { get; set; }

    }
}