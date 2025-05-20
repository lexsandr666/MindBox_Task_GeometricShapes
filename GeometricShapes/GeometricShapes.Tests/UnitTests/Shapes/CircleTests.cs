using GeometricShapes.Shapes;

namespace GeometricShapes.Tests.UnitTests.Shapes;

[TestFixture]
public class CircleTests
{
    [Test]
    public void CreateCircle_WithValidRadius_DoesNotThrow()
    {
        Assert.DoesNotThrow(() => new Circle(3));
    }

    [Test]
    public void GetArea_WithValidRadius_ReturnsCorrectArea()
    {
        var radius = 3;
        var circle = new Circle(radius);
        double expected = Math.PI * Math.Pow(radius, 2);
        Assert.That(circle.GetArea(), Is.EqualTo(expected).Within(1e-8));
    }

    [TestCase(0)]
    [TestCase(-5)]
    public void CreateCircle_WithNonPositiveRadius_ThrowsArgumentException(double radius)
    {
        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }
}