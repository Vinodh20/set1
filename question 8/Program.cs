using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //find the area of triangle

            Console.WriteLine("Enter the value of breadth in cm: ");
            float breadth = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of height: ");
            float height = float.Parse(Console.ReadLine());

            double area = ((breadth * height)/2);
                        
            Console.WriteLine("The area of the triangle is: "+ area);

           

        }
    }
}
