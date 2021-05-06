using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApplication1.Core;

namespace WebApplication1.Data
{
    public interface IRestaurantData
    {
       // IEnumerable<Restaurant> GetAll();
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
    }
    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
            new Restaurant { Id = 1, Name = "Pizza Hut", Location = "Mokdumpur", Cuisine = Restaurant.CuisineType.Indian },
            new Restaurant { Id = 2, Name = "Malaika", Location = "Rathbari", Cuisine = Restaurant.CuisineType.Italian },
            new Restaurant { Id = 3, Name = "Ashoka", Location = "Govindopur", Cuisine = Restaurant.CuisineType.Mexican },
            new Restaurant { Id = 3, Name = "Silver Arcade", Location = "Malda", Cuisine = Restaurant.CuisineType.Indian }
            }; 
            

        }
    
       /* public IEnumerable<Restaurant> GetAll()
        {
            //Link Query
            return from r in restaurants
                   orderby r.Id
                     select r;
           // throw new NotImplementedException();
        }*/
        public IEnumerable<Restaurant> GetRestaurantsByName(string name=null)
        {
            //Link Query
            return from r in restaurants
                   where string.IsNullOrEmpty(name)||r.Name.StartsWith(name)
                   orderby r.Id
                   select r;
            // throw new NotImplementedException();
        }
    }
}
