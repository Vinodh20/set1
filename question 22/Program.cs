using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_22
{
    class Program
    {
        static void Main(string[] args)
        {
            // find the compound interest

            Console.WriteLine("Enter the initial principle balance: ");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of times: ");
            float n = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the rate of interest: ");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of time period: ");
            int t = int.Parse(Console.ReadLine());

            //compound interest= (p*(1+r/n)^(nt))
            double nt = n * t;
            double val = 1 + ((r / 100) / n);
            double v = Math.Pow(val, nt);
            double ci = p * v;



            Console.WriteLine("The compound interest of given values is: " + ci);
            
        }
    }
}
