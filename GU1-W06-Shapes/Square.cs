using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GU1_W06_Shapes
{
    public class Square : Rectangle
    {
        public Square() : base(1.0, 1.0) { }

        public Square(double side) : base(side, side) { }

        public Square(double side, string color, bool filled) : base(side, side, color, filled) { }

        public double Side
        {
            get { return width; }
            set { width = length = value; }
        }

        public override double Width
        {
            get { return base.Width; }
            set { base.Width = base.Length = value; }
        }

        public override double Length
        {
            get { return base.Length; }
            set { base.Length = base.Width = value; }
        }

        public override string ToString()
        {
            return $"A Square with side={Side}, which is a subclass of {base.ToString()}";
        }
    }

}
