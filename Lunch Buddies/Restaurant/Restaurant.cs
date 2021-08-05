using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lunch_Buddies.Restaurant
{
    class Restaurant
    {
        public string RestaurantName { get; set; }

        private List<string> RestaurantNamesList { get; set; } = new List<string>()
        {
            "Five Points Pizza", "Two Boots Pizza", "Joe's Pizza", 
            "El Agavero", "Las Maracas", "El Fuego", "Uptown Taco",
            "Nicolettos", "Coco's Italian", "Amerigo", "Gino's East"
        };



        public Restaurant()
        {
            Random restaurant = new Random();
            int index = restaurant.Next(RestaurantNamesList.Count);
            RestaurantName = RestaurantNamesList[index];
        }

    }
}
