using FigureCalculator.Core.FigureType;

namespace AreaCalculatorTests;

public class CircleTests
{
    [Fact]
    public void test_calculate_area_on_circle_with_positive_radius_should_return_positive_value()
    {
        // Arrange
        const double radius = 5.0;
        var circle = new Circle(radius);

        // Act
        var actual = circle.CalculateArea();
        const double expect = Math.PI * radius * radius;

        // Assert
        Assert.Equal(expect, actual);
    }
    [Fact]
    public void test_create_circle_with_radius_zero_should_throw_exception()
    {
        // Arrange
        const double radius = 0.0;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }
    [Fact]
    public void test_create_circle_with_negative_radius_should_throw_exception()
    {
        // Arrange
        const double radius = -5.0;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }
}