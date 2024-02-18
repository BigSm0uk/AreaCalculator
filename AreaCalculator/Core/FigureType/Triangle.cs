using FigureCalculator.Core.Abstraction;
using FigureCalculator.Exceptions.TriangleExceptions;

namespace FigureCalculator.Core.FigureType;

/// <summary>
/// Класс для рассчета площади треугольника по 3 сторонам
/// </summary>
public class Triangle : Figure
{
    /// <param name="sideA">Сторона A.</param>
    /// <param name="sideB">Сторона B.</param>
    /// <param name="sideC">Сторона C.</param>
    public Triangle(double sideA, double sideB, double sideC)
    {
        if (!IsTriangleExist(sideA, sideB, sideC)) throw new InvalidTriangleException();
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    /// <summary>
    /// Сторона A.
    /// </summary>
    private double SideA { get; }

    /// <summary>
    /// Сторона B.
    /// </summary>
    private double SideB { get; }

    /// <summary>
    /// Сторона C.
    /// </summary>
    private double SideC { get; }
    

    private static bool IsTriangleExist(double sideA, double sideB, double sideC)
    {
        // Проверяем условие существования треугольника
        return sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA;
    }

    public bool IsRightAngled()
    {
        double[] sides = [SideA, SideB, SideC];
        const double eps = 0.000001;
        Array.Sort(sides);
        // Проверяем по теореме Пифагора, eps -> 0
        return Math.Abs(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) - Math.Pow(sides[2], 2)) < eps;
    }

    public override double CalculateArea()
    {
        var p = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
    }
}