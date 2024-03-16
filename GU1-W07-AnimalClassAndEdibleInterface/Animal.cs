using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GU1_W07_AnimalClassAndEdibleInterface
{
    public abstract class Animal
    {
        public abstract string MakeSound();
    }
    public class Tiger : Animal
    {
        public override string MakeSound()
        {
            return "Tiger: roarrrrr!";
        }
    }
    public class Chicken : Animal, IEdible
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

    public interface IEdible
    {
        string HowToEat();
    }
}
