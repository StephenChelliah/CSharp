using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StephenCSharp
{
    public class ifcondition_elseif
    {
        public int mar=5;
        public int marks { get; set; }
        public void printgrade()
        {
            Console.WriteLine($"The Given Marks is {marks}");
            if( marks>=80 )
            {
                Console.WriteLine("Honours");
                Console.WriteLine(mar);
            }
            else if(marks>=60)
            {
                Console.WriteLine("First Grade");
            }
            else if( marks>=40)
            {
                Console.WriteLine("Second Grade");
            }
            else
            {
                Console.WriteLine("Fail");
            }
          }

        public int unitsconsumed { get; set; }
        public decimal amount { get; set; }

        public void Calculate()
        {
            if(unitsconsumed<=200)
            {
                amount = unitsconsumed*0.5M;
            }
           else if(unitsconsumed<=400){
                amount = 100 + (unitsconsumed-200) * 0.65M;
            }
            else if( unitsconsumed<=600)
            {
                amount=230+(unitsconsumed-200) *0.8M;
            }
            else
            {
                amount = 390 + (unitsconsumed - 200) * 1.00M;
            }

        }

       public void display()
        {
            Console.WriteLine($"Amount is {amount}");
        }



    }
            
}
