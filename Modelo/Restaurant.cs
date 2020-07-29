using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba_Project.Modelo
{
    public class Restaurant
    {
        public int ID { get; set; }
        public string  Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}