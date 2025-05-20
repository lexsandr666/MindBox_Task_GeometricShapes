using GeometricShapes.Interfaces;
using GeometricShapes.Shapes;

namespace GeometricShapes.Tests.UnitTests.Interfaces;

[TestFixture]
public class IShapeTests
{
    [Test]
    public void GetArea_ViaIShape_ReturnsCorrectValues()
    {
        var shapesAreaResults = new Dictionary<IShape, double>
        {
            { new Circle(2), Math.PI * 4 },
            { new Triangle(3, 4, 5), 6 }
        };
        
        foreach (var shapeAreaResults in shapesAreaResults)
        {
            var shape = shapeAreaResults.Key;
            var expected = shapeAreaResults.Value;
            
            Assert.That(
                shape.GetArea(),
                Is.EqualTo(expected).Within(1e-8),
                $"Неверная площадь для {shape.GetType().Name}"
            );
        }
    }
}