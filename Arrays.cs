using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StephenCSharp
{
    public class Arrays
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[5];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;
            arr[4] = 5;

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine(arr[i]);
            }

             Console.WriteLine();
            //Another type of declaration
            char[] arr2 = { 'r', 'o', 'i','o','f','b','r','i'};

            for(int i=0;i<8;i++)
            {
                if(i==3||i==5)
                {
                    Console.Write(" ");
                }
                Console.Write(arr2[i]);
            }
            Console.WriteLine();
        }
    }
}