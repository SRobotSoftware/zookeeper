using System;
using System.Collections.Generic;

namespace ZooKeeper
{
    public class Enclosure
    {
        public string Name;
        public string Habitat;
        public List<Animal> Occupants = new List<Animal>();



        public void AddOccupant(Animal animal)
        {
            Occupants.Add(animal);
        }

        public override string ToString()
        {
            return string.Join(",", Occupants);
        }
        public void Log()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Habitat: {Habitat}");
            foreach (var occupant in Occupants)
            {
                Console.WriteLine(occupant.Name);
            }
        }
    }
}
