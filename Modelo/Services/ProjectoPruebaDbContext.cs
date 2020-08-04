using System;
using System.Collections.Generic;
using System.Data.Entity;
using Prueba_Project.Modelo;
using System.Linq;
using System.Web;

namespace Prueba_Project.Modelo.Services
{
    public class ProjectoPruebaDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}