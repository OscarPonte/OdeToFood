using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OdeToFood.Core;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();

    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        private List<Restaurant> _restaurants;
        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Lalaland", Location = "Wonderland", Cuisine = CuisineType.None},
                new Restaurant { Id = 2, Name = "Lolipop", Location = "Roma", Cuisine = CuisineType.Italian},
                new Restaurant { Id = 3, Name = "Madeira Club", Location = "Funchal", Cuisine = CuisineType.Portuguese},
                new Restaurant { Id = 4, Name = "Latin Party", Location = "Mexico", Cuisine = CuisineType.Mexican},
            };
        }



        public IEnumerable<Restaurant> GetAll()
        {
            return from r in _restaurants
                orderby r.Name
                select r;
        }
    }

   
}
