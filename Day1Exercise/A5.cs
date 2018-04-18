using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Exercise
{
    class A5
    {
        static void Main(string[] args)
        {
            //ask to enter a double precision number
            Console.Write("Enter a double precison number:");
            double input3 = Convert.ToDouble(Console.ReadLine());

            //output the input double precision number up to 2 decimal places
            Console.WriteLine("{0:0.00}", input3);
        }
    }
}
