using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Rectangle
{
    double width, height;
    public Rectangle()
    {
        this.width = 10.0;
        this.width = 5.0;
    }
    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }
    public double Area()
    {
        return this.width * this.height;
    }
    public double Perimeter()
    {
        return 2 * (this.width + this.height);
    }
    public string Inspect()
    {
        return $"Rectangle (WxH) {this.width} x {this.height}";
    }
}
