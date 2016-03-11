using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooKeeper
{
    class Program
    {
        static void Main(string[] args)
        {
            var TurtlePen = new Enclosure
            {
                Name = "Turtle Pen",
                Habitat = "Terrarium"

            };
            var ChickenCoop = new Enclosure
            {
                Name = "Chicken Coop",
                Habitat = "Coop"
            };
            var Franklin = new Animal
            {
                Name = "Sea Turtle",
                Gender = Animal.gender.male,
                Predator = true
            };
            var Shelly = new Animal
            {
                Name = "Sea Turtle",
                Gender = Animal.gender.female,
                Predator = true
            };
            var Kurt = new Animal
            {
                Name = "Chicken",
                Gender = Animal.gender.other,
                Predator = false
            };
            var Kortknee = new Rhino
            {
                
                Gender = Animal.gender.other,
                Predator = false
            };
            var Grain = new Food
            {
                Name = "Grain",
                IsLive = false
            };
            var Sardines = new Food
            {
                Name = "Sardines",
                IsLive = true
            };
            Kurt.Eat(Shelly);
            Console.ReadLine();
            Franklin.Eat(Grain);
            Console.ReadLine();
            Kortknee.Eat(Grain);
            Console.ReadLine();

            TurtlePen.AddOccupant(Shelly);
            TurtlePen.AddOccupant(Franklin);
            ChickenCoop.AddOccupant(Kurt);
            ChickenCoop.AddOccupant(Kortknee);
            ChickenCoop.log();
            
            Console.ReadLine();


        }
    }
}
