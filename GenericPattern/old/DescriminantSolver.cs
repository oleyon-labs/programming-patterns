using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPattern
{
    internal class DescriminantSolver : EquationSolver
    {
        public override (bool successful, double x1, double x2) FindSolution(double a, double b, double c)
        {
            double D = b * b - 4 * a * c;
            if(D < 0)
                return (false, double.NaN, double.NaN);
            else
            {
                return (true, (-b + Math.Sqrt(D) / (2 * a)), (-b - Math.Sqrt(D) / (2 * a)));
            }
        }
    }
}
