using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();
            myFamily.Add("otherSister", new Dictionary<string, string>() { { "name", "Krista" }, { "age", "42" } });
            myFamily.Add("sister", new Dictionary<string, string>() { { "name", "Syd" }, { "age", "33" } });
            myFamily.Add("mom", new Dictionary<string, string>() { { "name", "Evelyn" }, { "age", "64" } });
            myFamily.Add("brother", new Dictionary<string, string>() { { "name", "Mark" }, { "age", "41" } });

            foreach (var item in myFamily)
            {
                Console.WriteLine($"{item.Value["name"]} is my {item.Key} and is {item.Value["age"]}");
            }

        }
    }
}
