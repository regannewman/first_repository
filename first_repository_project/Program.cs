// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] list_of_things = {"pineapple", "orange", "carrot", "banana", "broccoli", "lettuce", "mango"};
            string[] list_of_fruit = {"apple", "grape", "orange", "pineapple", "tomato", "banana", "mango", "lime"};
            string[] list_of_veg = {"carrot", "potato", "broccoli", "lettuce", "squash"};

            List<string> fruits = new List<string>();
            List<string> veg = new List<string>();

            foreach(string item in list_of_things)
            {
                if(list_of_fruit.Contains(item.ToLower()))
                {
                    fruits.Add(item);
                }
                else if(list_of_veg.Contains(item.ToLower()))
                {
                    veg.Add(item);
                }else
                {
                    Console.WriteLine("This item is not a fruit or veggie, please try again!");
                }
            }

            Console.WriteLine("Here are the fruits: " );
            foreach(string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine("Here are the veg: " );
            veg.ForEach(veggie => Console.WriteLine(veggie));
            

        }
    }
}


