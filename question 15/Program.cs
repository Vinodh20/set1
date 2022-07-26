using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_15
{
    class Program
    {
        static void Main(string[] args)
        {
            //find the area of field and find in acres

            Console.WriteLine("Enter the length in ft: ");
            float length = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width in ft: ");
            float width = float.Parse(Console.ReadLine());

            float area = length * width;
            Console.WriteLine("The area of the field is: " + area + " sq ft");

            // 1 acre= 43,560 sq ft

            float acres = area / 43560;
            Console.WriteLine("The area of the field in acres is: " + acres + " acres");



        }

    }
}
