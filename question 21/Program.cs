using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_21
{
    class Program
    {
        static void Main(string[] args)
        {
            //calculate the simple interest

            Console.WriteLine("Enter the principle amount: ");
            float p = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the rate of interest: ");
            float r = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the no of years: ");
            float n = float.Parse(Console.ReadLine());

            float si = (p * n * r) / 100;

            Console.WriteLine("The simple interest of the given amount is: "+si);


        }
    }
}
