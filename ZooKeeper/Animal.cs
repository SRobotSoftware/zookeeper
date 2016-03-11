using System;

namespace ZooKeeper
{
    public class Animal : Food
    {
        public gender Gender;
        public bool Predator;

        public enum gender
        {
            Male = 0,
            Female = 1,
            Other = 2
        }

        public Animal()
        {
            IsLive = true;
        }

        public new string Name { get; set; }

        public void Eat(Food food)
        {
            if (food.IsLive)
                Console.WriteLine(Predator ? "NOM NOM NOM" : "I can't eat that!");
            else if (Predator)
                Console.Write("Get outta here!  You call this food?");
            else
                Console.WriteLine("Yummy Delicious");
        }
    }
}
