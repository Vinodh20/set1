using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of A: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of B: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("The value before swaping A is: " + a + " and B is: " + b);

            a = a ^ b;
            b = a ^ b;
            a = a ^ b;

            Console.WriteLine("The value after swaping A is: "+a + " and B is: "+ b);






        }
    }
}
