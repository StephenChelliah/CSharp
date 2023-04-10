using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StephenCSharp
{
    public class propertyFull
    {
        private int interestrate;

        public int Enterinterestrate
        {
            get { return interestrate; }
            set { 
                if(value<=0||value>40)
                {
                    Console.WriteLine($"Entered value {value} is Invalid");
                }
                else
                {
                    Console.WriteLine($"Entered value {value} is valid");
                }
                interestrate = value; }
        }

        public static void Main(string[] args)
        {
           

    }
    }
}
