using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StephenCSharp
{
    public class WritingStringintoFILE
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter String input 1");
            string str1=Console.ReadLine();
            Console.WriteLine("Enter String input 2");
            string str2=Console.ReadLine();
            string c1 = "Writing String input into File by using WriteallText method from FileObject of System.IO namespace " + str1;
            string c2 = "Writing String input into File by using AppendeallText method from FileObject of System.IO namespace " + str2;
            System.IO.File.WriteAllText(@"E:\C#Practise\code1.txt", c1);
            System.IO.File.WriteAllText(@"E:\C#Practise\code2.txt", c2);


        }
    }
}
