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
            var whit = new LunchBuddy("Whitney", "Adair");
            var alan = new LunchBuddy("Alan", "Fort");

            List<LunchBuddy> friends = new List<LunchBuddy>();

            friends.Add(sam);
            friends.Add(charlie);
            friends.Add(whit);
            friends.Add(alan);

            sam.Eat();
            Console.WriteLine();

            sam.Eat("steak");
            Console.WriteLine();

            sam.Eat(friends);
            Console.WriteLine();

            sam.Eat("bbq", friends);


        }
    }
}
