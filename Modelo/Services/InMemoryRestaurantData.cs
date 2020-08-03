using System;
using System.Collections.Generic;
using System.Linq;

namespace Prueba_Project.Modelo.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { ID = 1, Name = "Cicis Pizza", Cuisine = CuisineType.Italian },
                new Restaurant { ID = 2, Name = "Hut Pizza", Cuisine = CuisineType.French },
                new Restaurant { ID = 3, Name = "Indian Food", Cuisine = CuisineType.Indian }
            };


        }

        public Restaurant Get(int id)
        {
            return restaurants.FirstOrDefault(r => r.ID == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
            throw new NotImplementedException();
        }
    }
}
