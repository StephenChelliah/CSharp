using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StephenCSharp
{
    public class Switchcaseincsharp
    {
        public static void Main(string[] args)
        {
            int cr, pr, unit, rate, amt;
            char type;
            Console.Write("Enter Current Reading:");
            cr = int.Parse(Console.ReadLine());
            Console.Write("Enter Previous Reading:");
            pr = int.Parse(Console.ReadLine());
            unit=Math.Abs(cr-pr);
            Console.Write("Enter Connection Type: ");
            type=char.Parse(Console.ReadLine());   
            switch(type)
            {
                   case 'D':
                    rate = 2;
                    break;

                    case 'I':
                    rate = 6;
                    break;

                    case 'C':
                    rate = 4;
                    break;

                default:
                    Console.Write("Invalid Input");
                    rate = 0;
                    break;
            }
            amt = unit * rate;
            Console.WriteLine($"Bill Amount: {amt}");
        }

    }
}
