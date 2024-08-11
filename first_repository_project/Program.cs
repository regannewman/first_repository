// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> kvp = new Dictionary<int, string>()
            {
                {0, "zero"},
                {1, "one"},
                {2, "two"},
                {3, "three"},
                {4, "four"},
                {5, "five"}
            };

            var list_of_even = kvp.Where(x => x.Key%2 == 0).ToList();
            var list_of_odd = kvp.Where(y => y.Key%2 == 1).ToList();

            list_of_even.ForEach(even => Console.WriteLine($"{even.Key} : {even.Value}"));
            list_of_odd.ForEach(odd => Console.WriteLine($"{odd.Key} : {odd.Value}"));


            // create a list for each odd and even number

            // print out the key and value like this - 0 : "zero"

        }
    }
}


