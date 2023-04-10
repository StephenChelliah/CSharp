using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StephenCSharp
{
    public class Switchcase_Typecast
    {
        public static void Main(string[] args)
        {
        var input=Convert.ToInt32(Console.ReadLine());
            switch(input)
            {
                case 0:
                    {
                        Console.WriteLine("you have pressed the Key 0");
                        break;
                    }
                    case 1:
                    {
                        Console.WriteLine("you have pressed the Key 1");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("you have pressed the Key 2");
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("you have pressed the Wrong Key");
                        break;
                    }
            }
        }
    }        
}
