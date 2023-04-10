using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StephenCSharp
{
    public class BooleanCoupledwithANDoperators
    {
        public int mark1 { get; set; }
        public int mark2 { get; set; }

        public void DisplayResult()
        {
            bool passcondition1 = (mark1 >= 50) && (mark2 >= 50);
            bool passcondition2part1 = (mark2 >= 35) && (mark2 >= 35);
            bool passcondition2part2 = ((mark1 + mark2) / 2) >= 60;

            if((passcondition1==true)||(passcondition2part1==true&&passcondition2part2==true))
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("False");
            }

        }









    }
}
