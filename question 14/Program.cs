using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //generate random b/w a and b

            Console.WriteLine("Enter a random number A: ");
            int numberA = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter a random number B: ");
            int numberB = int.Parse(Console.ReadLine());

            Random r = new Random();
            int answer = r.Next(numberA, numberB);

            Console.WriteLine("The number between A and B: "+ answer);


        }
    }
}
