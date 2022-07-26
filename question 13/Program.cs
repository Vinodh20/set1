using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_13
{
    class Program
    {
        static void Main(string[] args)
        {
            // swap two variables without overflow

            Console.WriteLine("Enter the value of A: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of B: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("The value before swaping A is " + a + " and the B is " + b);

            int temp = a;
            a = b;
            b = temp;
            

            Console.WriteLine("The value after swaping A is " + a + " and the B is " + b);
        }
    }
}
