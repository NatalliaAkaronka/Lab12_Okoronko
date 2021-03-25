using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_Okoronko
{
    class Program
    {
        static double Pow(double a, int pow)
        {
            double result = 1;
            for (int i = 0; i < pow; i++) result *= a;
            return result;
        }

        static double SqrtN(double n, double A, double eps)
        {
            var x0 = A / n;
            var x1 = (1 / n) * ((n - 1) * x0 + A / Pow(x0, (int)n - 1));

            while (Math.Abs(x1 - x0) > eps)
            {
                x0 = x1;
                x1 = (1 / n) * ((n - 1) * x0 + A / Pow(x0, (int)n - 1));
            }

            return x1;
        }
        static void Main(string[] args)
        {
            Console.Title = "Вычисление корня n-ой степени из числа";
            Console.WriteLine("Введите число: ");
            double A = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите степень корня n: ");
            double n = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите точность: ");
            double точность = Double.Parse(Console.ReadLine());
            //Метод Ньютона
            Console.WriteLine("Вычисление корня методом Ньютона");
            Console.WriteLine(SqrtN(n, A, точность));
            //Math.Pow
            Console.WriteLine("Вычисление корня с помощью метода Math.Pow");
            Console.WriteLine(Math.Pow(A, (1 / n)));
            Console.ReadLine();
        }
    }
}
