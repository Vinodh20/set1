using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_18
{
    class Program
    {
        static void Main(string[] args)
        {
            //calculate the tip provided to waiter , at 5% of bill amount

            Console.WriteLine("Enter the value of bill amount: ");
            float amount = float.Parse(Console.ReadLine());
            
            double tip = 5.0 / 100 * amount;

                                      
            Console.WriteLine("The amount provided to waiter is: " + tip+ " rupees");

        }
    }
}
