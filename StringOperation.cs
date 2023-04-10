using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StephenCSharp
{
    public class StringOperation
    {
        public static void Main(string[] args)
        {
            String str = "Manchester United";
            Console.WriteLine(str);
            StringOperation strops = new StringOperation();
           string struppercase=str.ToUpper();
            Console.WriteLine(struppercase);
            Console.WriteLine(str);
            var now=DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine("After String Format");
            Console.WriteLine("Date is {0:d} and Time is {0:t}",now);

        }
    }
}
