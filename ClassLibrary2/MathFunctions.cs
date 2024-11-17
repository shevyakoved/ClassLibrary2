using System;

namespace MathLibrary
{
    public static class MathFunctions
    {
        // Умножение
        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        // Деление
        public static double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("На ноль делить нельзя.");
            return a / b;
        }

        // Расстояние между двумя точками
        public static double Distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        // Корни квадратного уравнения
        public static (double? x1, double? x2) SolveQuadratic(double a, double b, double c)
        {
            double discriminant = Math.Pow(b, 2) - 4 * a * c;
            if (discriminant < 0)
                return (null, null);
            double sqrtD = Math.Sqrt(discriminant);
            return ((-b + sqrtD) / (2 * a), (-b - sqrtD) / (2 * a));
        }

        // Сумма геометрической прогрессии
        public static double GeometricSum(double firstTerm, double ratio, int n)
        {
            if (ratio == 1)
                return firstTerm * n;
            return firstTerm * (1 - Math.Pow(ratio, n)) / (1 - ratio);
        }
    }
}
