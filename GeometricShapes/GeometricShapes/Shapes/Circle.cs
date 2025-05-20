using GeometricShapes.Interfaces;
using GeometricShapes.Models;

namespace GeometricShapes.Shapes;

public class Circle : Shape
{
    private readonly double _radius;

    public Circle(double radius)
    {
        _radius = radius;
        
        Validate();
    }
    
    public override double GetArea() => Math.PI * Math.Pow(_radius, 2);
    
    protected override void Validate()
    {
        if (_radius <= 0)
            throw new ArgumentException("Радиус должен быть больше 0");
    }
}