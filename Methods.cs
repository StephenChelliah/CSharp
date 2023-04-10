using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StephenCSharp
{
    public class Methods
    {
        public static void Main(string[] args)
        {
            add(5,7);
            add1(4, 5, 8);
            add1("John");
            strops("Dan", "Jacob");
            var trump = charops('E');
            Console.WriteLine(trump);


        }
            static void add(int a, int b)
            {
                int c = a + b;
                Console.WriteLine(c);
            }

            static void add1(int a, int b, int c)
            {
                int d = a + b + c;
                Console.WriteLine(d);
            }

        static void add1(string a)
        {
            Console.WriteLine(a);
        }

        static void strops(string a, string b)
            {
                Console.WriteLine("String value is " + a + " , " + b);

            }

            static char charops(char a)
            {
                return a;
            }
    }
}
