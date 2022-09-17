using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(20);
            c1.Area();
            Console.WriteLine(c1);


            Reactangle R1 = new Reactangle(12.5,15.6);
            R1.Area();
            Console.WriteLine(R1);

            Sphere S1 = new Sphere(23.5);
            S1.Area();
            Console.WriteLine(S1);



        }
    }
}
