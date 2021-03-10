using System;
using System.Collections.Generic;
using System.Linq;

namespace AreaSolverLibrary
{
    public class AreaSolver
    {
        /// <summary>
        /// Вычисляет площадь круга по радиусу
        /// </summary>
        /// <param name="r">Радиус круга</param>
        /// <returns>Площадь круга</returns>
        public double GetCircleArea(double r)
        {
            return Math.PI * r*r;
        }

        /// <summary>
        /// Вычисляет площадь треугольника по трём сторонам
        /// </summary>
        /// <param name="a">Первая сторона треугольника</param>
        /// <param name="b">Вторая сторона треугольника</param>
        /// <param name="c">Третья сторона треугольника</param>
        /// <returns>Площадь треугольника</returns>
        public double GetTriangleArea(double a, double b, double c)
        {
            double p = (a + b + c) / 2d;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        
        /// <summary>
        /// Вычисляет площадь фигуры
        /// </summary>
        /// <param name="values">Радиус круга или стороны треугольника</param>
        /// <returns>Площадь фигуры</returns>
        public double GetArea(params double[] values)
        {
            if (values.Length == 1) return GetCircleArea(values[0]);
            if (values.Length == 3) return GetTriangleArea(values[0], values[1], values[2]);
            throw new Exception("Передано неверное количество аргументов.");
        }

        /// <summary>
        /// Проверяет, является ли треугольник прямоугольным
        /// </summary>
        /// <param name="a">Первая сторона</param>
        /// <param name="b">Вторая сторона</param>
        /// <param name="c">Третья сторона</param>
        /// <returns>Является ли треугольник прямоугольным</returns>
        public bool IsTriangleRight(double a, double b, double c)
        {
            List<double> sides = new List<double>() {a, b, c};
            double hypotenuse = sides.Max();
            sides.Remove(hypotenuse);
            return Math.Abs(hypotenuse - Math.Sqrt(sides[0] * sides[0] + sides[1] * sides[1])) < double.Epsilon;
        }
    }
}
