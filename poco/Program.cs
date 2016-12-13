using poco.Model;
using System;
using System.Collections.Generic;

namespace poco //plain-old class objects
{
    class Program
    {
        static void Main(string[] args)
        {
            var produce = new List<Produce>();
            
            //this creates a new object
            //assigns it to variable
            //then adds it to the list
            
            //using custom contructor
            var f1 = new Fruit("Apple", 5.5, 10);
            produce.Add(f1);

            //using no-args constructor
            var f2 = new Fruit();
            f2.Name = "Kiwi";
            f2.Weight = 3.2;
            f2.Quantity = 30;
            produce.Add(f2);

            //this is the slightly different way
            produce.Add(new Vegetable());
            ((Vegetable)produce[2]).Name = "Carrot";
            ((Vegetable)produce[2]).Weight = 1.2;
            ((Vegetable)produce[2]).Quantity = 5;

            Console.WriteLine("there are " + produce.Count + " items");

            foreach (var item in produce)
            {
                Console.WriteLine(item + ", total weight: " + ProduceUtility.GetItemWeight(item) + "oz");
            }

            Console.WriteLine("Total Weight: " + ProduceUtility.GetTotalWeight(produce) + "oz");
        }
    }
}
