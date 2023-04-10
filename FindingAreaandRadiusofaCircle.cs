using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StephenCSharp
{
    public class FindingAreaandRadiusofaCircle
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("We are going to find out the Radius of a Circle");
            Radius();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("We are going to find out the Area of a Circle");
            Area();
        }

        public static void Radius()
        {
            //Calculate the Radius of a Circle
            double area;
            double radius;
            Console.WriteLine("Enter the Area of a Circle");
            area=double.Parse(Console.ReadLine());
            radius = Math.Sqrt(area * 7.0 / 22);
            Console.WriteLine($"Radius of a Circle is {radius}");
        }

        public static void Area()
        {
            //Calculate the Area of a Circle
            double radius;
            double area;
            Console.WriteLine("Enter the Radius");
            radius=double.Parse(Console.ReadLine());
            area= 3.141592*radius*radius;
            Console.WriteLine($"Area of a Circle is {area}");
        }
    }
}
