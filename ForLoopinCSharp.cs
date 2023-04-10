using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StephenCSharp
{
    public class ForLoopinCSharp
    {
        public static void Main(string[] args)
        {
            int prime = 0,checkvalue;
            Console.Write("Enter the value you what to check: ");
           checkvalue=int.Parse(Console.ReadLine());

            for(int i=2;i<checkvalue;i++)
            {
                if(checkvalue%i==0)
                {
                    prime = 1;
                    break;
                }
            }

            if(prime==0)
            {
                Console.WriteLine("It is a PrimeNumber");
            }
            else
            {
                Console.Write("It is not a PrimeNumber");
            }

        }
    }
}
