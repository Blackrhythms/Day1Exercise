using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Exercise
{
    class A1
    {
        static void Main(string[] args)
        {
            //ask to enter a name
            Console.Write("Enter name:");
            string name = Console.ReadLine();
            //ask to enter an email address
            Console.Write("Enter email:");
            string email = Console.ReadLine();

            //output name and email
            Console.WriteLine("Name:"+name);
            Console.WriteLine("Email:"+email);
        }
    }
}
