using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_lab2._4_DayToMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A Programe to convert days to months and days");
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("Enter number of days to convert: ");
            int daysInput = Int32.Parse(Console.ReadLine());

            int days = daysInput % 30;
            int months = (daysInput - days) / 30;
            Console.WriteLine($"{daysInput} day is {months} Months and {days} Days.");
        }
    }
}
