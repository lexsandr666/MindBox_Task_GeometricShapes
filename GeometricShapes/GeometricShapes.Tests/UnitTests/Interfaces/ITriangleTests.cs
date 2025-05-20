using GeometricShapes.Interfaces;
using GeometricShapes.Shapes;

namespace GeometricShapes.Tests.UnitTests.Interfaces;

[TestFixture]
public class ITriangleTests
{
    [Test]
    public void IsRightTriangle_ViaIRightTriangle_ReturnsExpectedValues()
    {
        var triangles = new Dictionary<ITriangle, bool>
        {
            { new Triangle(3, 4, 5), true },
            { new Triangle(5, 12, 13), true },
            { new Triangle(2, 3, 4), false },
            { new Triangle(1, 1, 1), false }
        };

        foreach (var kv in triangles)
        {
            ITriangle triangle = kv.Key;
            bool expected = kv.Value;
            
            Assert.That(
                triangle.IsRectangular(),
                Is.EqualTo(expected),
                $"Triangle sides expected IsRectangular={expected}"
            );
        }
    }
}