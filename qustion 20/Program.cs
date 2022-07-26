using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qustion_20
{
    class Program
    {
        static void Main(string[] args)
        {
            //calculate the gross pay

            Console.WriteLine("Enter the basic pay: ");
            float pay = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the DA%: ");
            float DA = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the TA%: ");
            float TA = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the PF deduction %: ");
            float PF = float.Parse(Console.ReadLine());

            //finding DA% , TA% , PF%

            float da = (DA / 100) * pay;
            float ta = (TA / 100) * pay;
            float pf = (PF / 100) * pay;

            // gross salary:

            float grosspay = (pay + da + ta) - pf;

            Console.WriteLine("The gross pay is: "+grosspay+ " rupees");
        }
    }
}
