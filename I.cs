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
            Console.WriteLine("A - Pole sześciana, B - Objętość koła, C - Objętość walca");
            Console.WriteLine("Prosze podaj co chcesz obliczyć");
            string inp = Console.ReadLine().ToUpper();
            double x = double.Parse(Console.ReadLine());
            double r = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            switch (inp)
            {
                case "A":
                    Console.WriteLine(6*(x*x));
                    break;
                case "B":
                    Console.WriteLine(4/3*x*(r*r*r));
                    break;
                case "C":
                    Console.WriteLine(x*(r*r)*h);
                    break;
                default:
                    Console.WriteLine("Nie ma takiej metody");
                    break;
            }
            Console.ReadKey();

        }
    }
}
       
