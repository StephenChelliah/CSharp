using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StephenCSharp
{
    public class SimpleInterest
    {
        public static void Main(string[] args)
        {
            /*
             * Write a Program to read Principal,Rate of Interest,years of investment
             * and display the simple Interest.(Using the formula : SI=PRT/100)
             * P-Principal , R-rate of interest ,T-No of years
             */
            int p, r, t,SI;
            Console.WriteLine("Enter the Principal");
            p=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Rate of Interest");
            r=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your no of Years");
            t=int.Parse(Console.ReadLine());

            SI = (p * r * t) / 100;

            Console.WriteLine($"Simple Interest is {SI}");
            Console.WriteLine("After String Format");
            Console.WriteLine($"Simple Interest is {SI:0.00}");

        }
    }
}
