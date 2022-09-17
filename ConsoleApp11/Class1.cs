using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    abstract public class Shape
    {
        public abstract void Area();
    }
    public class Circle : Shape

    {
        private double radius, area;

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override void Area()
        {
            area = 3.14 * radius * radius;
        }
        public override string ToString()
        {
            return $"area of circle is {area}";

        }

    }
    public class  Reactangle :Shape
    {
        private double length, breadth, area;

        public Reactangle(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
            
        }
        public override void Area()
        {
            area = length * breadth;
        }
        public override string ToString()
        {
            return $"Area of rectangle is {area}";
        }
    }
    public class Sphere :Shape
    {
        private double radius, area;

        public Sphere(double radius)
        {
            this.radius= radius;
        }
        public override void Area()
        {
            area = 4 * 3.14 * radius * radius;

        }
        public override string ToString()
        {
            return $"Area of sphere is {area}";
        }


    }
}
