using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equality_Comparison_and_Operator_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Duck, String> duckFacts = GetDuckFacts();
            var sq = new Duck("Sir Quackalot", "Mallard", 100, 17);
            Console.WriteLine(duckFacts[sq]);
            Console.ReadLine();
        }

        private static Dictionary<Duck,String> GetDuckFacts()
        {
            Dictionary<Duck, String> duckFacts = new Dictionary<Duck, String>
            {
                { new Duck("Sir Quackalot", "Mallard", 100, 17), "He quacks a lot." },
                { new Duck("Quack Sparrow", "Fulvous Whistling", 132, 12), "He sails the seven ponds." },
                { new Duck("Quackie Chan", "Albio", 13, 3), "He will quack you up"},
                { new Duck("Duck Norris", "West Indian Whistling", int.MaxValue, int.MaxValue), "He is the reason Waldo is hiding..." },
                { new Duck("Firequacker", "Black-bellied Whistling", 108, 31), "" }
            };
            return duckFacts;
        }
    }
}
