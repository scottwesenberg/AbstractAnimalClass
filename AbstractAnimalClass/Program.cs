﻿using System;
using System.Xml.Linq;

namespace Animals
{
    abstract class Animal

    {
        // Property
        public abstract string Name { get; set; }
        // Methods
        public abstract string Describe();
        public string whatAmI()
        {
            return "I am an animal";
        }
    }

    class Program
    {
        class Squirrel : Animal
        {
            // override the abstract property
            public override string Name { get; set; }
            public string Type { get; set; }

            public Squirrel()
            {
                Name = string.Empty;
                Type = string.Empty;
            }
            public Squirrel(string name, string type)
            {
                Name = name;
                Type = type;
            }
            // override the abstract method
            public override string Describe()
            {
                return "I am a " + Type + "\nMy name is " + Name;
            }

        }
        static void Main(string[] args)
        {
            // Create Horse object 
            Squirrel chip = new Squirrel();
            chip.Name = "Chip";
            chip.Type = "Squirrel";
            Console.WriteLine(chip.whatAmI());
            Console.WriteLine(chip.Describe());
        }
    }
}