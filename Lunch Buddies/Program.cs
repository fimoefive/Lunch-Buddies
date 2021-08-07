using System;
using System.Collections.Generic;

namespace Lunch_Buddies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lunch Buddies");

            var sam = new LunchBuddy("Sam", "Douglas");
            var charlie = new LunchBuddy("Charlie", "Rose");
            var whit = new LunchBuddy("Whitney", "Adams");
            var alan = new LunchBuddy("Alan", "Fort");
            var kyle = new LunchBuddy("Kyle", "Grove");

            List<LunchBuddy> friends = new List<LunchBuddy>();

            friends.Add(sam);
            friends.Add(charlie);
            friends.Add(whit);
            friends.Add(alan);
            friends.Add(kyle);

            sam.Eat();
            Console.WriteLine();

            sam.Eat("steak");
            Console.WriteLine();

            sam.Eat(friends);
            Console.WriteLine();

            sam.Eat("French Dip Sandwich", friends);


        }
    }
}
