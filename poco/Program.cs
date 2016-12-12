using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poco //plain-old class objects
{
    class Program
    {
        static void Main(string[] args)
        {
            var produce = new List<object>();
            
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

            //this is the slightly easier way
            produce.Add(new Vegetable());
            ((Vegetable)produce[2]).Name = "Carrot";
            ((Vegetable)produce[2]).Weight = 1.2;
            ((Vegetable)produce[2]).Quantity = 5;

            Console.WriteLine("there are " + produce.Count + " items");

            foreach (var item in produce)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Fruit
    {
        //don't have to declare a contructor method
        //one is provided for you "no-arguments contructor"

        //this is a no-arguments contructor
        public Fruit()
        {
            //see... no arguments
        }

        //this is a custom constructor
        public Fruit(string name, double weight, int quantity)
        {
            Name = name;
            Weight = weight;
            Quantity = quantity;
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private double weight;
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public int Quantity { get; set; }
        
        //tells the compiler that you want to use
        //this version on the ToString method
        public override string ToString()
        {
            return Name + "(" + Weight + "oz) : " + Quantity;
        }
    }

    class Vegetable
    {
        //no-args contructor
        public Vegetable()
        {
        }

        //custom constructor
        public Vegetable(string name, double weight, int quantity)
        {
            Name = name;
            Weight = weight;
            Quantity = quantity;
        }

        //encapsulated data
        private string name;
        public string Name
        {
            get { return name.ToUpper(); }
            set { name = value; }
        }
        private double weight;
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public int Quantity { get; set; }

        //tells the compiler that you want to use
        //this version on the ToString method
        public override string ToString()
        {
            return Name + "(" + Weight + "oz) : " + Quantity;
        }
    }
}
