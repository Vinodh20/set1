using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_23
{
    class Program
    {
        static void Main(string[] args)
        {
            // calculate the height in cm to feet and inches

            Console.WriteLine("Enter the height in cm: ");
            float cm = float.Parse(Console.ReadLine());

            // 1 inch = 2.54cm and 12inch = 1 foot

            double inch = cm / 2.54;
            double feet = inch / 12;

            Console.WriteLine("The height in cm to inch: "+ inch+" inches");
            Console.WriteLine("The height in cm to feet: "+ feet+" ft");






        }
    }
}
