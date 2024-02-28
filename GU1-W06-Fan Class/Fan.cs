using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GU1_W06_Fan_Class
{
    public class Fan
    {
        public const int SLOW = 1;
        public const int MEDIUM = 2;
        public const int FAST = 3;
        private int speed;
        private bool on;
        private double radius;
        private string color;
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public bool On
        {
            get { return on; }
            set { on = value; }
        }

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public Fan()
        {
            speed = SLOW;
            on = false; 
            radius = 5;
            color = "blue";
        }

        public string ToString()
        {
            return (on ? $"Speed: {this.speed} - " : "") + $"Color: {this.color} - Radius: {this.radius} - Fan is {(on ? "ON" : "OFF")}";
        }
    }
}
