using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPattern
{
    internal abstract class EquationSolver
    {
        void Solve()
        {
            var coeffs = AskForCoefficients();
            var res = FindSolution(coeffs.a, coeffs.b, coeffs.c);
            PrintResult(res.successful, res.x1, res.x2);
        }
        public (double a, double b, double c) AskForCoefficients()
        {
            double a, b, c;
            Console.WriteLine("Введите a");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите b");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите c");
            c = double.Parse(Console.ReadLine());
            return (a, b, c);
        }
        abstract public (bool successful, double x1, double x2) FindSolution(double a, double b, double c);
        public void PrintResult(bool isSuccessful, double x1, double x2)
        {
            if(!isSuccessful)
            {
                Console.WriteLine("Решений нет");
            }
            else
            {
                Console.WriteLine($"x1 = {x1}, x2 = {x2}");
            }
        }
    }
}
