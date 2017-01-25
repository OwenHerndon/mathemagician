using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMagician
{
    class Program
    {
        static void Main(string[] args)
        {
            //enter a numer
            //Console.WriteLine("Please enter a number");
            //int number = Console.ReadLine();
            //check for valid number

            Console.WriteLine("What would you like me to do?");
            Console.WriteLine("Select an operation");
            Console.WriteLine(); //write out array of operations

            string command = Console.ReadLine();
            //check if valid operation

            Console.WriteLine("How many should i print");

            string how_many = Console.ReadLine();
            //check for valid input
            //convert string to int

            Console.WriteLine($"Cool, I'm going to print {how_many} {command} numbers.");

            //print results

            Console.WriteLine("Press anykey to end.");
            Console.ReadKey();
        }
    }
}
