using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A - Pole kuli, B - Objętość kuli, C - X, E - EXIT");
            Console.WriteLine("Prosze podaj co chcesz obliczyć");
            string inp = Console.ReadLine().ToUpper();
            double x = double.Parse(Console.ReadLine());
            double r = double.Parse(Console.ReadLine());
            switch (inp)
            {
                case "A":
                    Console.WriteLine(4 / 3 * x * (r * r * r));
                    break;
                case "B":
                    Console.WriteLine(4 * x * (r*r));
                    break;
                case "C":
                    Console.WriteLine();
                    break;
                case "E":
                    Console.WriteLine("EXIT");
                    break;
            }
            Console.ReadKey();

        }
    }
}
       
