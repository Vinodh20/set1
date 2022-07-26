using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_19
{
    class Program
    {
        static void Main(string[] args)
        {
            //calculate the net amount backward

            //given by user:
            Console.WriteLine("Enter the total amount: ");
            float Tamount = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the tax percentage: ");
            float tax = float.Parse(Console.ReadLine());

            /* initial price= x, tax= y total amount= z
               initial price + (tax/100* initial price)= total amount
                x(1+y/100)=z
                x= z/1+y/100  */

            //net amount backward:
            float netamount = Tamount / (1 + (tax / 100));


            Console.WriteLine("The net amount backward is: "+netamount+" rupees");



        }
    }
}
