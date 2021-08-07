using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lunch_Buddies
{
    class Restaurant
    {
        public string RestaurantName { get; set; }

        private List<string> RestaurantNameList = new List<string>()
        {
            "five points pizza", "two boots pizza", "joe's pizza",
            "el agavero", "las maracas", "el fuego", "uptown taco",
            "nicolettos", "coco's italian", "amerigo", "gino's east"
        };

        public Restaurant()
        {
            Random rnd = new Random();
            int index = rnd.Next(RestaurantNameList.Count);
            RestaurantName = RestaurantNameList[index];
        }

    }
}
