using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_2
{
    class Program
    {
        static void Main(string[] args)
        {

            // program to find the power of the value a


            Console.WriteLine("Enter the value of a: ");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of power: ");
            int power = int.Parse(Console.ReadLine());

            double valueraised = Math.Pow(A, power);

            Console.WriteLine("The value raised is: "+ valueraised);

        }
    }
}
