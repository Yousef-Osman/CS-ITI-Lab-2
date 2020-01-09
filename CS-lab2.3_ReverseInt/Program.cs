using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_lab2._3_ReverseInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A Programe to Reverse a number");
            Console.WriteLine("------------------------------");
            int number;
            Console.Write("Enter a number to reverse: ");
            number = Int32.Parse(Console.ReadLine());
            int reversedNumber = ReverseInter(number);

            Console.WriteLine($"Reversed Number is: {reversedNumber}");
        }

        public static int ReverseInter(int number)
        {
            int remainder, reversedNumber = 0;
            while (number != 0)
            {
                remainder = number % 10;
                reversedNumber = reversedNumber * 10 + remainder;
                number = number / 10;
            }
            return reversedNumber;
        }
    }
}
