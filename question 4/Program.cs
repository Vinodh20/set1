using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //find the perimeter of circle

            Console.WriteLine("Enter the value of radius in cm: ");
            float radius = float.Parse(Console.ReadLine());

            double perimter = 2 * Math.PI * radius;


            Console.WriteLine("The perimeter of the circle is: "+ perimter);


        }
    }
}
