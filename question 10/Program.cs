using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //convert celsius to fehrenheit

            Console.WriteLine("Enter the value of celsius: ");
            float celsius =float.Parse(Console.ReadLine());

            double fehrenheit = (celsius * 9.0 / 5) + 32;

            Console.WriteLine("The value of fehrenheit is: "+ fehrenheit);

        }
    }
}
