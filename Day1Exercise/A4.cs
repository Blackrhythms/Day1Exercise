using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Exercise
{
    class A4
    {
        static void Main(string[] args)
        {
            //ask to enter a double precision number
            Console.Write("Enter a double precision number:");
            double input2 = Convert.ToDouble(Console.ReadLine());

            //output the square of input double precision number
            Console.WriteLine(Math.Pow(input2, 2));
        }
    }
}
