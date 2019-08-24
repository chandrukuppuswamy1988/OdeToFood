using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        public IEnumerable<Restaurant> restaurants { get; set; }

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>() {
                new Restaurant(){ Id = 1,Name = "Saravana Bhavan",Cuisine=CuisineType.Indian ,Location="New Jersy"},
                new Restaurant(){ Id = 1,Name = "Mary Land",Cuisine=CuisineType.Italian,Location="San Fransico"},
                new Restaurant(){ Id = 1,Name = "Cinnomon Club",Cuisine=CuisineType.Mexican,Location="London"},
                new Restaurant(){ Id = 1,Name = "La Costa",Cuisine=CuisineType.Mexican,Location="Portugal"}
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
           
        }
    }
}
