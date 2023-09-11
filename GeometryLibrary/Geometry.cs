using System;

namespace GeometryLibrary
{
    public static class GeometryFigure
    {
        // Вычисление площади круга по радиусу
        public static double CalculateCircleArea(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус не может быть меньше нуля.");

            return Math.PI * Math.Pow(radius, 2);
        }

        // Вычисление площади треугольника по трем сторонам
        public static double CalculateTriangleArea(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                throw new ArgumentException("Длины сторон треугольника не могут быть меньше нуля.");

            double s = (side1 + side2 + side3) / 2;
            return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }

        // Проверка, является ли треугольник прямоугольным
        public static bool IsRightTriangle(double side1, double side2, double side3)
        {
            double[] sides = { side1, side2, side3 };
            Array.Sort(sides);

            double a = sides[0];
            double b = sides[1];
            double c = sides[2];

            return Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2);
        }
    }
}
