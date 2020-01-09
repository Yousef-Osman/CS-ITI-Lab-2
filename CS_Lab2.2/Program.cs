using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lab2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateRoot();
        }

        public static void CalculateRoot()
        {
            int a, b, c;
            double checkRoot, imgNum, v1, v2, x1, x2;
            Console.WriteLine("A Programe to solve a second degree equation in the Form of (ax^2 + bx + c = 0)");
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.Write("Enter Your First Value a: ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter Your First Value b: ");
            b = Int32.Parse(Console.ReadLine());
            Console.Write("Enter Your First Value c: ");
            c = Int32.Parse(Console.ReadLine());

            checkRoot = (b * b) - (4 * a * c);

            if (checkRoot > 0)
            {
                x1 = (-b * 1.0 + Math.Sqrt(checkRoot)) / 2 * a;
                x2 = (-b * 1.0 - Math.Sqrt(checkRoot)) / 2 * a;
                Console.WriteLine($"First root = {x1}");
                Console.WriteLine($"Second root2 = {x2}");
            }
            else if (checkRoot == 0)
            {
                x1 = -b / (2.0 * a);
                Console.WriteLine($"First root = Second root = {x1}");
            }
            else if (checkRoot < 0)
            {
                imgNum = Math.Sqrt(-checkRoot) / (2.0 * a);

                v1 = (-b / 2.0 * a);
                v2 = (-b / 2.0 * a);
                string root1 = string.Format($"{v1} + {imgNum}i");
                string root2 = string.Format($"{v2} - {imgNum}i");
                Console.WriteLine($"First Root = {root1}");
                Console.WriteLine($"Second Root = {root2}");
            }
        }
    }
}
