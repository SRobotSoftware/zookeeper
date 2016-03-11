using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooKeeper
{
    public class Animal: Food
    {

        public gender Gender;
        public bool Predator;

        public enum gender
        {
            male,
            female,
            other
        }
        public Animal()
        {
            base.IsLive = true;
        }
        public void Eat(Food food)
        {
            if (food.IsLive)
            {
                if (Predator)
                {
                    Console.WriteLine("NOM NOM NOM");

                }
                else
                {
                Console.WriteLine("I can't eat that!");

                }
            }
            else
            {
                if (!Predator)
                {
                    Console.WriteLine("Yummy Delicious");
                }
                else
                {
                    Console.Write("Get outta here!  You call this food?");
                }
            }
        }

    }
}
