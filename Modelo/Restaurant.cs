using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Prueba_Project.Modelo
{
    public class Restaurant
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string  Name { get; set; }
        [Required]
        [Display(Name="Type of food")]
        public CuisineType Cuisine { get; set; }
    }
}