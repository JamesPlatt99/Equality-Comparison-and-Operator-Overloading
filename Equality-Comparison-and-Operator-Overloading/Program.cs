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
            List<Duck> ducks = GetDucks();
            ducks.Sort();
            ducks.ForEach(PrintDuckFact);
            Console.ReadLine();
        }

        private static void PrintDuckFact(Duck duck)
        {
            Dictionary<Duck, String> duckFacts = GetDuckFacts();
            if (duckFacts.ContainsKey(duck)) {
                Console.WriteLine($"{duck.Name}: {duckFacts[duck]}");
            }
            else
            {
                Console.WriteLine($"{duck.Name} is undocumented, how mysterious...");
            }
        }

        private static List<Duck> GetDucks()
        {
            var ducks = new List<Duck>(){
                new Duck("Mother Ducker","Albio", 100, 10),
                new Duck("Sir Quackalot", "Mallard", 100, 17), 
                new Duck("Quack Sparrow", "Fulvous Whistling", 132, 12),
                new Duck("Quackie Chan", "Albio", 13, 3),
                new Duck("Duck Norris", "West Indian Whistling", int.MaxValue, int.MaxValue)
            };
            return ducks;
        }

        private static Dictionary<Duck,String> GetDuckFacts()
        {
            var duckFacts = new Dictionary<Duck, String>
            {
                { new Duck("Sir Quackalot", "Mallard", 100, 17), "He quacks a lot." },
                { new Duck("Quack Sparrow", "Fulvous Whistling", 132, 12), "He sails the seven ponds." },
                { new Duck("Quackie Chan", "Albio", 13, 3), "He will duck you up"},
                { new Duck("Duck Norris", "West Indian Whistling", int.MaxValue, int.MaxValue), "He is the reason Waldo is hiding..." }
            };
            return duckFacts;
        }
    }
}
