using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //program to display sum, difference, product

            Console.WriteLine("enter the first number:");
            int firstnumber = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the second number:");
            int secondnumber = int.Parse(Console.ReadLine());

            int sum = firstnumber + secondnumber;
            int product = firstnumber * secondnumber;
            int differnce = Math.Abs(firstnumber - secondnumber);

            Console.WriteLine("The sum of the two numbers is : "+ sum);
            Console.WriteLine("The difference of the two numbers is : " + differnce);
            Console.WriteLine("The product of the two numbers is : " + product);




        }
    }
}
