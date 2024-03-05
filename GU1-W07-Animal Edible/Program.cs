using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GU1_W07_Animal_Edible
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[2];
            animals[0] = new Tiger();
            animals[1] = new Chicken();

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.MakeSound());

                if (animal is Chicken)
                {
                    Edible edibler = (Chicken)animal;
                    Console.WriteLine(edibler.HowToEat());
                }
            }
            Console.ReadKey();
        }
    }

    public abstract class Animal
    {
        public abstract string MakeSound();
    }
    public interface Edible
    {
        string HowToEat();
    }
    public class Tiger : Animal
    {
        public override string MakeSound()
        {
            return "Tiger: roarrrrr!";
        }
    }
    public class Chicken : Animal, Edible
    {
        public override string MakeSound()
        {
            return "Chicken: cluck-cluck!";
        }

        public string HowToEat()
        {
            return "could be fried";
        }
    }
}
