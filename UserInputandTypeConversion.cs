using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StephenCSharp
{
    public class UserInputandTypeConversion
    {
     public static void Main(string[] args)
        {
            int p, n, r, si;

            //Any input we receive from the user will be in String Format.
            //Two ways of receiving input from the user.
            //1. datatype.Parse(Console.ReadLine());
            //2.Convert.Datatype(Console.ReadLine()):

            Console.Write("Enter value for p:");
            p=int.Parse(Console.ReadLine());

            Console.Write("Enter value for n:");
            n = int.Parse(Console.ReadLine());

            Console.Write("Enter value for r:");
            r = Convert.ToInt32(Console.ReadLine());

            si = (p * n * r) / 100;

            Console.WriteLine($"Simple Interest : {si}");
            
        }

    }
}
