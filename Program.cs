using System;

namespace Inheritance
{
    // base class
    class Animal
    {
        public string name;
        // constructor
        public Animal()
        {
            name = "";
        }
        //parameterized constructor
        public Animal(string name)
        {
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine($"I am an animal, my name is {name}");
        }
    }

    // derived class of Animal 
    class Reptile : Animal
    {
        public string species;
        public string habitat;
        public int legs;

        //constructor
        public Reptile() : base() //calls animal class constructor
        {
            species = "";
            habitat = "";
            legs = 0;
        } //end constructor

        //parameterized constructor
        public Reptile(string name, string species, string habitat, int legs) : base(name)
        {
            this.species = species;
            this.habitat = habitat;
            this.legs = legs;
        }
        public void Species()
        {
            Console.WriteLine($"My species is {species}.");
        }
        public void Habitat()
        {
            Console.WriteLine($"My habitat is {habitat}.");
        }
        public void Legs()
        {
            Console.WriteLine($"I have {legs} legs.");
        }

    } //end reptile class

    class Mammal : Animal
    {
        public bool domestication;
        public string color;
        public string diet;

        public Mammal() : base()
        {
            domestication = false;
            color = "";
            diet = "";
        }

        public Mammal(string name, bool domestication, string color, string diet) : base(name)
        {
            this.domestication = domestication;
            this.color = color;
            this.diet = diet;
        }

        public void printMammal()
        {
            Console.WriteLine($"I can be domesticated: {domestication}.");
            Console.WriteLine($"The color of my fur/hair is {color}.");
            Console.WriteLine($"My diet consists of {diet}");
        }
    } //end mammal class
    class Program
    {
        static void Main(string[] args)
        {
            // object of base class
            Animal myPet = new Animal();
            myPet.name = "Sparky";
            myPet.display();
            Console.WriteLine();

            // derived class object using default constructor
            Reptile snake = new Reptile();
            snake.name = "Slither";
            snake.species = "Snake";
            snake.habitat = "Land or Water";
            snake.legs = 0;
            Console.WriteLine("Printing first class with constructor");
            snake.display();
            snake.Species();
            snake.Habitat();
            snake.Legs();
            Console.WriteLine();

            //derived class object using parameterized constructor
            Reptile gator = new Reptile("Toothy", "Alligator", "Water", 4);
            Console.WriteLine("Printing first class with parameterized constructor");
            gator.display();
            gator.Species();
            gator.Habitat();
            gator.Legs();
            Console.WriteLine();

            Mammal horse = new Mammal();
            horse.name = "Black Beauty";
            horse.domestication = true;
            horse.color = "black";
            horse.diet = "grains and grass";
            Console.WriteLine("Printing second class with constructor");
            horse.display();
            horse.printMammal();
            Console.WriteLine();

            Mammal moose = new Mammal();
            moose.name = "Bullwinkle";
            moose.domestication = false;
            moose.color = "brown";
            moose.diet = "plants";
            Console.WriteLine("Printing second class with parameterized constructor");
            moose.display();
            moose.printMammal();

        }

    }
} //end inheritance namespace