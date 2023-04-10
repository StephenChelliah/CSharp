using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StephenCSharp
{
    public class Arithmetic_Logical_Operations
    {
        public static void Main(string[] args)
        {
            int n1, n2,g;
            Console.WriteLine("Enter First Number");
             n1 =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
             n2=int.Parse(Console.ReadLine());
            //IF condition
            g=(n1>n2)?n1: n2;

            Console.WriteLine($"The Greatest Number is {g}");

        }
    }
}
