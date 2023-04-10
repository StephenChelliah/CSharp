using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StephenCSharp
{
    public class StringInterpolation
    {
        public static void Main(string[] args)
        {
            string a = "India is my Country";
            int b = a.Length;
            Console.WriteLine($"Length of a is {b}");
            Console.WriteLine($"Second Character of string variable a is {a[0]}");
            string x=$"The given string is {a.ToUpper()} and {b*20}";
            Console.WriteLine(x);

            String firstname = "Stephen";
            String lastname = "Chelliah";
            int age = 28;

            Console.WriteLine("Your Firstname is " + firstname + " " + " and your lastname is " + lastname);
            Console.WriteLine("Your age is " + age);
            Console.WriteLine();
            Console.WriteLine("Output with String Interpolation");
            Console.WriteLine();
            Console.WriteLine($"Your Firstname is {firstname} and your lastname is {lastname}");
            Console.WriteLine($"Your age is {age}");
            
        }
    }
}
