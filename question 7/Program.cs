using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //find the square root of the given number

            Console.WriteLine("Enter the number: ");
            float number = float.Parse(Console.ReadLine());

            double squareroot = Math.Sqrt(number);

            Console.WriteLine("The square root of the given number is: "+ squareroot);


        }
    }
}
