using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lunch_Buddies
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

        public string Eat()
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"\n\n{FirstName} {LastName} is at {restaurant.RestaurantName} restaurant.");
            return restaurant.RestaurantName;
        }

        public void Eat(string food)
        {
            Console.WriteLine($"\n\n{FirstName} {LastName} ate {food} at the office today.");
        }

        public void Eat(List<LunchBuddy> companions)
        {
                var restaurant = new Restaurant();
                Console.Write($"\n\n{FirstName} {LastName} is at {restaurant.RestaurantName} with ");
                for (var i = 0; i < companions.Count; i++)
                {
                    if (FirstName == companions[i].FirstName)
                    {
                        Console.Write("");
                    }
                    else if (i < companions.Count - 1)
                    {
                        Console.Write($"{companions[i].FirstName}, ");
                    }
                    else
                    {
                        Console.Write($"and {companions[i].FirstName}.");
                    }
                }

            }


        public void Eat(string food, List<LunchBuddy> companions)
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"\n\n{FirstName} {LastName} ordered {food} at {restaurant.RestaurantName} restaurant.");
            for (var i = 0; i < companions.Count; i++)
            {
                if (FirstName == companions[i].FirstName)
                {
                    Console.Write("");
                }
                else if (i < companions.Count - 1)
                {
                    Console.Write($"{companions[i].FirstName}, ");
                }
                else
                {
                    Console.WriteLine($"{companions[i].FirstName} is with us too!");
                }
            }
        }


    }

}
