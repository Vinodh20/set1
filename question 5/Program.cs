using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //find the quotient and remainder

            Console.WriteLine("Enter the numerator in whole number: ");
            int numerator = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the denominator in whole number: ");
            int denominator = int.Parse(Console.ReadLine());

            int quotient = numerator / denominator;
            int remainder = numerator % denominator;

            Console.WriteLine("The value of quotient is: "+ quotient);
            Console.WriteLine("The value of remainder is: " + remainder);




        }
    }
}
