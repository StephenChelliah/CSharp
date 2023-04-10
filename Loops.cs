using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StephenCSharp
{
    public class Loops
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Forloop iteration:" + " " + i);
            }
            Console.WriteLine();    
            int z = 5;
            while (z != 0)
            {
                Console.WriteLine("WhileLoop iteration:" + " " + z);
                z--;
            }
            Console.WriteLine();
            int j = 0;
            do
            {
                Console.WriteLine("This will be executed anyway irrespective of the condition being satisfied or not.Because it is dowhile loop ");

            } while (j != 0);

        }
    }
}

    

