using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StephenCSharp
{
    public class SwitchCase
    {
        public int Grade { get; set; }

        public void Display()
        {
            switch(Grade)
            {
                case 1:
                case 5: 
                case 7:
                    Console.WriteLine("Hall No: 1");
                    break;
                    case 2:
                    case 3:
                    case 6:
                    case 8:
                     Console.WriteLine("Hall No: 2");
                    break;

                    case 4:
                    case 9:
                    case 10:
                    Console.WriteLine("Hall No:3");
                    break;

                default:
                    Console.WriteLine("Invalid Grade!");
                    break;

            }
        }


        public string petanimalname { get; set; }

        public struct animals
        {
            public const string cat = "cat";
            public const string dog = "dog";
            public const string rat = "rat";
            public const string sparrow = "sparrow";
            public const string parrot = "parrot";

        }


        public void DisplayIncentive()
        {
            Console.WriteLine("Enter your petanimalname");
            Console.WriteLine();
            switch (petanimalname)
            {
                case animals.cat:
                    Console.WriteLine("Incentive 15%");
                    break;
                case animals.dog:
                    Console.WriteLine("Incentive 20%");
                    break;
                case animals.rat:
                    Console.WriteLine("Incentive 5");
                    break;
                case animals.sparrow:
                    Console.WriteLine("Incentive 25%");
                    break;
                case animals.parrot:
                    Console.WriteLine("Incentive 20%");
                    break;

                default:
                    Console.WriteLine("You have entered the wrong value");
                    break;

            }



            }
        }
    }

