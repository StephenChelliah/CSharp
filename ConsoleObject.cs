using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StephenCSharp
{
    public class ConsoleObject
    {
        public static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Learning C# is very Interesting");

            //Exercise:-
            Console.Write("Enter your Name ");
            var name=Console.ReadLine();
            Console.WriteLine($"Hi <{name}> ,Welcome");
            Console.WriteLine($"<{name}>, You are so special to me");
            Console.WriteLine($"<{name}>, let this moment be a great one");
            Console.WriteLine("Jesus is my God.");
            Console.WriteLine("All Praises are to Jesus only.");


        }
    }
}
