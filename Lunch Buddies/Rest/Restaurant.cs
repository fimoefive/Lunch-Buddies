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

       // private List<string> RestaurantNamesList { get; set; } = new List<string>()
        //{
        //    "Five Points Pizza", "Two Boots Pizza", "Joe's Pizza", 
        //    "El Agavero", "Las Maracas", "El Fuego", "Uptown Taco",
        //    "Nicolettos", "Coco's Italian", "Amerigo", "Gino's East"
        //};

    //public Restaurant()
    //{
    //    Random rnd = new Random();
    //    int index = rnd.Next(RestaurantNamesList.Count);
    //    RestaurantName = RestaurantNamesList[index];
    //}

    private List<string> RestaurantNames = new List<string>();
        public Restaurant()
        {
            RestaurantNames.Add("Amerigo");
            RestaurantNames.Add("Baja Burrito");
            RestaurantNames.Add("Edley's");


            Random rnd = new Random();
            int index = rnd.Next(RestaurantNames.Count);
            RestaurantName = RestaurantNames[index];
        }

    }
}
