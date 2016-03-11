using System;

namespace ZooKeeper
{
    class Program
    {
        static void Main()
        {
            var turtlePen = new Enclosure
            {
                Name = "Turtle Pen",
                Habitat = "Terrarium"

            };
            var chickenCoop = new Enclosure
            {
                Name = "Chicken Coop",
                Habitat = "Coop"
            };
            var franklin = new Animal
            {
                Name = "Sea Turtle",
                Gender = Animal.gender.Male,
                Predator = true
            };
            var shelly = new Animal
            {
                Name = "Sea Turtle",
                Gender = Animal.gender.Female,
                Predator = true
            };
            var kurt = new Animal
            {
                Name = "Chicken",
                Gender = Animal.gender.Other,
                Predator = false
            };
            var kortknee = new Animal
            {
                Name = "Rhino",
                Gender = Animal.gender.Other,
                Predator = false
            };
            var grain = new Food
            {
                Name = "Grain",
                IsLive = false
            };
            var sardines = new Food
            {
                Name = "Sardines",
                IsLive = true
            };
            kurt.Eat(shelly);
            Console.ReadLine();
            franklin.Eat(grain);
            Console.ReadLine();
            kortknee.Eat(grain);
            Console.ReadLine();
            franklin.Eat(sardines);
            Console.ReadLine();

            turtlePen.AddOccupant(shelly);
            turtlePen.AddOccupant(franklin);
            chickenCoop.AddOccupant(kurt);
            chickenCoop.AddOccupant(kortknee);
            chickenCoop.Log();
            
            Console.ReadLine();


        }
    }
}
