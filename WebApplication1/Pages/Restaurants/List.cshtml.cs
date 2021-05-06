using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using WebApplication1.Core;
using WebApplication1.Data;

namespace WebApplication1.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IRestaurantData restaurantData;
        public string Message;
        public IEnumerable<Restaurant> Restaurants { get; set; }

        [BindProperty(SupportsGet =true)]
        public String SearchTerm { get; set; }
        public ListModel(IConfiguration config,IRestaurantData restaurantData)
        {
            this.config = config;
            this.restaurantData = restaurantData;
        }
              

      /*  public void OnGet()
        {
            // Message = "Hello World from PageModel";
            //HttpContext.Request
            Message = config["Message"];
            Restaurants = restaurantData.GetAll();
        }*/
        /*public void OnGet( string searchTerm)
        {
            // Message = "Hello World from PageModel";
            //Message = config["Message"];
            Restaurants = restaurantData.GetRestaurantsByName(searchTerm);
        }*/
        public void OnGet()
        {
            // Message = "Hello World from PageModel";
           // Message = config["Message"];
            Restaurants = restaurantData.GetRestaurantsByName(SearchTerm);
        }
    }
}
