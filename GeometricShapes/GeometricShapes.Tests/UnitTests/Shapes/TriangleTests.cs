using GeometricShapes.Shapes;

namespace GeometricShapes.Tests.UnitTests.Shapes;

[TestFixture]
public class TriangleTests
{
    [Test]
    public void CreateTriangle_WithValidSides_DoesNotThrow()
    {
        Assert.DoesNotThrow(() => new Triangle(3, 4, 5));
    }

    [Test]
    public void GetArea_WithValidSides_ReturnsArea()
    {
        var triangle = new Triangle(3, 4, 5);
        
        Assert.That(triangle.GetArea(), Is.EqualTo(6).Within(1e-8));
    }

    [TestCase(0, 1, 1)]
    [TestCase(1, -1, 1)]
    public void CreateTriangle_WithNonPositiveSide_ThrowsArgumentException(double a, double b, double c)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
    }
}