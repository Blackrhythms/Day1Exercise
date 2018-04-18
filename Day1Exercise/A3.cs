using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Exercise
{
    class A3
    {
        static void Main(string[] args)
        {
            //ask to enter an integer
            Console.Write("Enter an integer:");
            int input = Convert.ToInt32(Console.ReadLine());

            //output the square of input integer
            Console.WriteLine(input * input);

        }
    }
}
