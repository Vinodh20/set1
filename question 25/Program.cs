using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the candidate roll number: ");
            int rollno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the candidate name: ");
            string name = (Console.ReadLine());
            Console.WriteLine("Enter the science mark: ");
            int Smark = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the maths mark: ");
            int Mmark = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the computer science mark: ");
            int CSmark = int.Parse(Console.ReadLine());

            int total = Smark + CSmark + Mmark;
            int average = total / 3;

            Console.WriteLine("The total of 3 subjects: "+total);
            Console.WriteLine("The average of 3 subjects: " + average);
            

        }
    }
}
