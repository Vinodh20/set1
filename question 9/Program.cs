using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // To convert kilogram to miles and miles to kilogram

            Console.WriteLine("Enter the value of kilogram : ");
            float kilogram = float.Parse(Console.ReadLine());

            double miles = kilogram * 0.621371;

            Console.WriteLine("The value of miles is: " + miles);

            Console.WriteLine("Enter the value of miles: ");
            float mile = float.Parse(Console.ReadLine());

            double kilograms = mile * 1.60934;

            Console.WriteLine("The value of kilograms is: " + kilograms);
            

        }
    }
}
