using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StephenCSharp
{
    public class IFCondition
    {
        public static void Main(string[] args)
        {

            var Enteredinput = Console.ReadLine();
            var password ="Raja";

            if(Enteredinput==password)
            {
                Console.WriteLine("You have entered the correct password");
            }
            else
            {
                Console.WriteLine("Wrong Password");
            }
        }
    }
}
