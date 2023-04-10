using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StephenCSharp
{
    public class NestedIFCondition
    {

        public void greatestnumber(int firstnumber, int secondnumber, int thirdnumber)
        {

            if (firstnumber > secondnumber)
            {
                if (firstnumber > thirdnumber)
                {
                    Console.WriteLine($"Greatest Number is Firstnumber {firstnumber}");
                }

                else
                {
                    Console.WriteLine($"Greatest Number is Thirdnumber {thirdnumber}");
                }
            }

            else
            {
                if (secondnumber > thirdnumber)
                {
                    Console.WriteLine($"Greatest Number is SecondNumber {secondnumber}");
                }
                else
                {
                    Console.WriteLine($"Greatest Number is ThirdNumber {thirdnumber}");
                }
            }

        }

        public void GreatestFourNumbers(int firstno, int secondno, int thirdno, int fourthno)
        {
            if (firstno > secondno && firstno > thirdno && firstno > fourthno)
            {
                Console.WriteLine($"FirstNumber {firstno} is Greatest");
            }
            else if (secondno > thirdno && secondno > fourthno) 
            {
                Console.WriteLine($"SecondNumber {secondno} is Greatest");
            }
            else { 
            
                if (thirdno > fourthno)
                {
                    Console.WriteLine($"ThirdNumber {thirdno} is Greatest");
                }
                else
                {
                    Console.WriteLine($"FourthNumber {fourthno} is Greatest");
                }
            }
        }
    }
}