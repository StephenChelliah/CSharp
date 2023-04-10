using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StephenCSharp
{
    public class Properties
    {
        //Simple Property Example
        public int Principalamount { get; set; }
        public int Yearsofinvestment { get; set; }

        public int Interestpercent { get; set; }

        //Propg   Example
        private int Simpleinterest;

        public int Interestcalculation
        {
            get { return Simpleinterest; }
            

        }

        public void InterestcalculationFunction()
        {
            Simpleinterest = (Principalamount * Yearsofinvestment * Interestpercent)/100;
        }

        //Property Full Example
        private string BankName;

        public string EnterBankName
        {
            get { return BankName; }
            set { BankName = value; }
        }

        public static void Main(string[] args)
        { 
           Properties probj = new Properties();
            probj.EnterBankName = "HDFC BANK";
            probj. Principalamount = 1000;
            probj.Interestpercent = 8;
            probj.Yearsofinvestment = 1;
            probj.InterestcalculationFunction();
            Console.WriteLine(probj.EnterBankName);
            Console.WriteLine(probj.Interestcalculation);

        }
    }
}


       

           



    
