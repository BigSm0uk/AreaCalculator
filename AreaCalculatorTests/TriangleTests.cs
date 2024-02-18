using FigureCalculator.Core.FigureType;
using FigureCalculator.Exceptions.TriangleExceptions;

namespace AreaCalculatorTests;

public class TriangleTests
{
    [Fact]
    public void test_valid_triangle()
    {
        // Arrange
        const double sideA = 3;
        const double sideB = 4;
        const double sideC = 5;

        // Act
        var triangle = new Triangle(sideA, sideB, sideC);

        // Assert
        Assert.NotNull(triangle);
    }

    [Fact]
    public void test_calculate_area()
    {
        // Arrange
        const double sideA = 3;
        const double sideB = 4;
        const double sideC = 5;
        var triangle = new Triangle(sideA, sideB, sideC);

        // Act
        var actual = triangle.CalculateArea();
        const double expected = 6d;

        // Assert
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void test_is_right_angled_true()
    {
        // Arrange
        const double sideA = 3;
        const double sideB = 4;
        const double sideC = 5;
        var triangle = new Triangle(sideA, sideB, sideC);

        // Act
        var isRightAngled = triangle.IsRightAngled();

        // Assert
        Assert.True(isRightAngled);
    }
    [Fact]
    public void test_zero_side_exception()
    {
        // Arrange
        const double sideA = 0;
        const double sideB = 4;
        const double sideC = 5;

        // Act & Assert
        Assert.Throws<InvalidTriangleException>(() => new Triangle(sideA, sideB, sideC));
    }
    [Fact]
    public void test_negative_side_exception()
    {
        // Arrange
        const double sideA = -3;
        const double sideB = 4;
        const double sideC = 5;

        // Act & Assert
        Assert.Throws<InvalidTriangleException>(() => new Triangle(sideA, sideB, sideC));
    }
    
    [Fact]
    public void test_triangle_inequality_exception()
    {
        // Arrange
        const double sideA = 1;
        const double sideB = 2;
        const double sideC = 5;

        // Act & Assert
        Assert.Throws<InvalidTriangleException>(() => new Triangle(sideA, sideB, sideC));
    }
}