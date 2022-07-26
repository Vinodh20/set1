using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //find the square of the given number

            Console.WriteLine("Enter the whole number: ");
            int number = int.Parse(Console.ReadLine());

            double square = Math.Pow(number, 2);

            Console.WriteLine("The square of the given number is: "+ square);


        }
    }
}
