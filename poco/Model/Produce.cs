﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poco.Model
{
    class Produce
    {
        //don't have to declare a contructor method
        //one is provided for you "no-arguments contructor"

        //but if you use a custom contructor
        //a no-args constructor has to be made

        //this is a no-arguments contructor
        public Produce()
        {
            //see... no arguments
        }

        //this is a custom constructor
        public Produce(string name, double weight, int quantity)
        {
            Name = name;
            Weight = weight;
            Quantity = quantity;
        }


        //this is a getter/setter method
        //created by using the
        //refactor->encapsulate field option
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

        //this is a getter/setter method
        public int Quantity { get; set; }

        //tells the compiler that you want to use
        //this version on the ToString method
        public override string ToString()
        {
            return Name + "(" + Weight + "oz) : " + Quantity;
        }
    }
    
    //declaring Fruit as a subclass to Produce
    class Fruit : Produce
    {
        //no-args constructor
        public Fruit()
        {
        }

        //allows fruit to inherit everything from Produce
        public Fruit(string name, double weight, int quantity) :
            base(name, weight, quantity)
        {
        }

        //adds to base class' override
        public override string ToString()
        {
            return "Fruit: " + base.ToString();
        }
    }

    //declaring Vegetable as a subclass to Produce
    class Vegetable : Produce
    {
        //no-args contructor
        public Vegetable()
        {
        }

        //custom constructor
        public Vegetable(string name, double weight, int quantity) :
            base(name, weight, quantity)
        {
        }
        
        //adds to base class' override
        public override string ToString()
        {
            return "Vegetable: " + base.ToString();
        }
        
    }
}
