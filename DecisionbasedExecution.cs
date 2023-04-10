using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StephenCSharp
{
    public class DecisionbasedExecution
    {
        public static void Main(string[] args)
        {
            int jan, feb, mar, tot, avg;
            Console.Write("Enter sales of Jan:");
            jan = int.Parse(Console.ReadLine());

            Console.Write("Enter sales of Feb:");
            feb = int.Parse(Console.ReadLine());

            Console.Write("Enter sales of Mar:");
            mar = int.Parse(Console.ReadLine());

            tot = jan + feb + mar;

            avg = tot / 3;

            Console.WriteLine(tot);
            Console.WriteLine(avg);


            int inc;

            if (jan > 15 && feb > 15 && mar > 15)
            {
                if (avg >= 75)
                {
                    inc = (tot * 20) / 100;
                    
                }
                else if(avg>=50)
                {
                    inc = (tot * 10) / 100;
                }
                else if(avg>=25)
                {
                    inc = (tot * 5) / 100;
                }
                else
                {
                    inc = 0;
                }
                Console.WriteLine($"Incentive is:{inc}");
            }

            
        }
    }
}
