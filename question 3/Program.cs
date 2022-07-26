using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //program to find the volume of rectangle water tank

            Console.WriteLine("Enter the length in cm : ");
            float length = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the breadth in cm: ");
            float breadth = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height in cm: ");
            float height = float.Parse(Console.ReadLine());
            
           
            float volume = length * breadth * height;

            Console.WriteLine("The volume of water tank is: "+ volume);



        }
    }
}
