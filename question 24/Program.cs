using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_24
{
    class Program
    {
        static void Main(string[] args)
        {
            // find the bmi

            Console.WriteLine("Enter the height in m: ");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the weight in kg: ");
            float weight = float.Parse(Console.ReadLine());

            //bmi= weight/height *height

            double bmi = weight / Math.Pow(height,2);

            Console.WriteLine("The BMI of given height and weight is: "+ bmi);





        }
    }
}
