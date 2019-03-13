using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();
            myFamily.Add("sister", new Dictionary<string, string>() { { "name", "Heily" }, { "age", "20" } });
            myFamily.Add("Father", new Dictionary<string, string>() { { "name", "Nick" }, { "age", "52" } });
            myFamily.Add("Mother", new Dictionary<string, string>() { { "name", "Naina" }, { "age", "48" } });

            foreach (var (relationship, information) in myFamily)
            {
               Console.WriteLine($"{information["name"]} is my {relationship} and is {information["age"]} years old.");
                
            };

            Console.ReadLine();
        }

    }
}
