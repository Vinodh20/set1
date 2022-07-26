using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_16
{
    class Program
    {
        static void Main(string[] args)
        {
            //FIND THE SUM OF ALL NATURAL NUMBERS UPTO N

            Console.WriteLine("Enter the natural number N: ");
            int n = int.Parse(Console.ReadLine());

            //formula for sum of all natural numbers upto N
            int sum = (n * (n + 1)) / 2;

            Console.WriteLine("The sum of all natural numbers upto N is: "+sum);
        }
    }
}
