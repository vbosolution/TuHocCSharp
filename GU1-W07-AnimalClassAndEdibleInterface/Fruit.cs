using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GU1_W07_AnimalClassAndEdibleInterface
{
    public abstract class Fruit : IEdible
    {
        public abstract string HowToEat();
    }
    public class Apple : Fruit
    {
        public override string HowToEat()
        {
            return "Apple could be slided";
        }
    }
    public class Orange : Fruit
    {
        public override string HowToEat()
        {
            return "Orange could be juiced";
        }
    }
}
