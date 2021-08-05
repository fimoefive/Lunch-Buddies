using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lunch_Buddies.Restaurant;

namespace Lunch_Buddies.LunchBuddy
{
    class LunchBuddy
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public LunchBuddy(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }

        public void Eat()
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"{FirstName} {LastName} is at {restaurant.RestaurantName} restaurant.");
            return restaurant.RestaurantName;
        }

        public void Eat(string food)
        {
            Console.WriteLine($"{FirstName} {LastName} ate {food} at the office today.");
        }



    }
}
