using GeometricShapes.Interfaces;

namespace GeometricShapes.Models;

public abstract class Shape : IShape
{
    protected abstract void Validate();
    public abstract double GetArea();
}