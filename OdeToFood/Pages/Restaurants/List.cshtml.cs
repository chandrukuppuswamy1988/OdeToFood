using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OdeToFood.Data;
using OdeToFood.Core;

namespace OdeToFood.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        public IConfiguration config { get; set; }
        public IEnumerable<Restaurant> restaurants { get; set; }
        public string Message { get; set; }
        public IRestaurantData restaurantData {get;set;}

        public ListModel(IConfiguration config, IRestaurantData restaurantData)
        {
            this.config = config;
            this.restaurantData = restaurantData;
        }

        public void OnGet()
        {
            this.restaurants = this.restaurantData.GetAll();
            this.Message = this.config["Message"];
        }
    }
}