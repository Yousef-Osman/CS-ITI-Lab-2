using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lab2
{
    public enum Position { Manager = 1, Technition = 2, Adminstrator = 3 }
    public enum TypeOfJob { FullTime = 1, PartTime = 2}
    public struct Employee
    {
        public int id;
        public string name;
        public double salary;
        public int position;
        public int typeOfJob;        
    }
       
    
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("A Programe to fill and print employee data");
            Console.WriteLine("------------------------------------------");
            Employee emp;
            FillStudent(out emp);
            PrintStudent(emp);
        }

        public static void FillStudent(out Employee e)
        {
            Console.Write("Enter Employee ID: ");
            e.id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee name: ");
            e.name = Console.ReadLine();
            Console.Write("Enter Employee salary: ");
            e.salary = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Position in numbers (1.Manager, 2.Technition, 3.Adminstrator): ");            
            e.position = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee type of job in numbers (1.FullTime, 2.PartTime): ");
            e.typeOfJob = Convert.ToInt32(Console.ReadLine());
        }

        public static void PrintStudent(Employee e)
        {
            Console.WriteLine();
            Console.WriteLine($"Employee ID is : {e.id}");
            Console.WriteLine($"Employee name is : {e.name}");
            Console.WriteLine($"Employee net salary is : {0.9 * e.salary}");
            Console.WriteLine($"Employee position is : {(Position)e.position}");
            Console.WriteLine($"Employee type of job is : {(TypeOfJob)e.typeOfJob}");
        }
    }
}
