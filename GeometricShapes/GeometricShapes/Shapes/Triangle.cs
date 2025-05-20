using System.Runtime.CompilerServices;
using GeometricShapes.Interfaces;
using GeometricShapes.Models;

namespace GeometricShapes.Shapes;

public class Triangle : Shape, ITriangle
{
    private readonly double _sideA;
    private readonly double _sideB;
    private readonly double _sideC;

    public Triangle(double sideA, double sideB, double sideC)
    {
        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;

        Validate();
    }
    
    public override double GetArea()
    { 
        var semiperimeter = (_sideA + _sideB + _sideC) / 2;
        return Math.Sqrt(semiperimeter * (semiperimeter - _sideA) * (semiperimeter - _sideB) * (semiperimeter - _sideC));
    }

    public bool IsRectangular()
    {
        double[] sides = [_sideA, _sideB, _sideC];
        Array.Sort(sides);

        double cathetusSquareSum = Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
        double hypotenuseSquare = Math.Pow(sides[2], 2);

        return cathetusSquareSum == hypotenuseSquare;
    }

    protected override void Validate()
    {
        ValidateSideLength(_sideA);
        ValidateSideLength(_sideB);
        ValidateSideLength(_sideC);
    }
    
    private static void ValidateSideLength(double length, 
        [CallerArgumentExpression("length")] string paramName = null!)
    {
        if (length <= 0)
            throw new ArgumentException($"Сторона треугольника {paramName} должна быть больше 0!");
    }
}