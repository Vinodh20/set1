using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_17
{
    class Program
    {
        static void Main(string[] args)
        {
            //find the average of the 3 input values

            Console.WriteLine("Enter the value 1: ");
            float value1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value 2: ");
            float value2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value 3: ");
            float value3 = float.Parse(Console.ReadLine());

            //average formula
            float average = (value1 + value2 + value3) / 3;

            Console.WriteLine("The average of the 3 numbers is: " + average + " %");

             

        }
    }
}
