using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StephenCSharp
{
    public class ContinueBreak
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Continue Program");
            for (int i=0;i<=5;i++)
            {
                
                if(i==3)
                {
                   Console.WriteLine("We are going to skip the below statements");
                    continue;
                }
                Console.WriteLine(i);

            }

            Console.WriteLine();
            Console.WriteLine("Break Program");
            for(int j=0;j<=5;j++)
            {
                if(j==3)
                {
                    Console.WriteLine("We are going to break the loop completely");
                    break;
                }
                Console.WriteLine(j);
            }
        }
    }
}
