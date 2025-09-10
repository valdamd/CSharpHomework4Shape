using FluentAssertions;
using ShapeAlgorithm;
using ShapeAlgotithm;
using Xunit;

namespace TestShape;

public sealed class ShapeTests
{
    [Fact]
    public void Circle_CorrectArea()
    {
        var circle = new Circle(2);
        circle.CalculateArea().Should().BeApproximately(Math.PI * 4, 0.001);
    }

    [Fact]
    public void Circle_CorrectPerimeter()
    {
        var circle = new Circle(2);
        circle.CalculatePerimeter().Should().BeApproximately(2 * Math.PI * 2, 0.001);
    }

    [Fact]
    public void Circle_CorrectToString()
    {
        var circle = new Circle(2);
        circle.ToString().Should().Contain("Shape: Circle");
        circle.ToString().Should().Contain($"Radius: {2}");
        circle.ToString().Should().Contain($"Perimeter: {2 * Math.PI * 2:F2}");
        circle.ToString().Should().Contain($"Area: {Math.PI * 4:F2}");
    }

    [Fact]
    public void Rectangle_CorrectArea()
    {
        var rectangle = new Rectangle(4, 5);
        rectangle.CalculateArea().Should().Be(20);
    }

    [Fact]
    public void Rectangle_CorrectPerimeter()
    {
        var rectangle = new Rectangle(4, 5);
        rectangle.CalculatePerimeter().Should().Be(18);
    }

    [Fact]
    public void Rectangle_CorrectToString()
    {
        var rectangle = new Rectangle(4, 5);
        rectangle.ToString().Should().Contain("Shape: Rectangle");
        rectangle.ToString().Should().Contain("Width: 4, Height: 5");
        rectangle.ToString().Should().Contain($"Perimeter: {18:F2}");
        rectangle.ToString().Should().Contain($"Area: {20:F2}");
    }

    [Fact]
    public void Square_CorrectArea()
    {
        var square = new Square(3);
        square.CalculateArea().Should().Be(9);
    }

    [Fact]
    public void Square_CorrectPerimeter()
    {
        var square = new Square(3);
        square.CalculatePerimeter().Should().Be(12);
    }

    [Fact]
    public void Square_CorrectToString()
    {
        var square = new Square(3);
        square.ToString().Should().Contain("Shape: Square");
        square.ToString().Should().Contain($"Side: {3}");
        square.ToString().Should().Contain($"Perimeter: {12:F2}");
        square.ToString().Should().Contain($"Area: {9:F2}");
    }

    [Fact]
    public void Triangle_CorrectArea()
    {
        var triangle = new Triangle(3, 4, 5);
        triangle.CalculateArea().Should().BeApproximately(6, 0.01);
    }

    [Fact]
    public void Triangle_CorrectPerimeter()
    {
        var triangle = new Triangle(3, 4, 5);
        triangle.CalculatePerimeter().Should().Be(12);
    }

    [Fact]
    public void Triangle_CorrectToString()
    {
        var triangle = new Triangle(3, 4, 5);
        triangle.ToString().Should().Contain("Shape: Triangle");
        triangle.ToString().Should().Contain("Sides: 3, 4, 5");
        triangle.ToString().Should().Contain($"Perimeter: {12:F2}");
        triangle.ToString().Should().Contain($"Area: {6:F2}");
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-5)]
    public void Circle_InvalidRadius_Throws(double radius)
    {
        Action act = () => new Circle(radius);
        act.Should().Throw<ArgumentOutOfRangeException>().WithParameterName("radius");
    }

    [Theory]
    [InlineData(0, 5)]
    [InlineData(5, -2)]
    public void Rectangle_InvalidDimensions_Throws(double width, double height)
    {
        Action act = () => new Rectangle(width, height);
        act.Should().Throw<ArgumentOutOfRangeException>()
           .Where(e => e.ParamName == "width" || e.ParamName == "height");
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void Square_InvalidSide_Throws(double side)
    {
        Action act = () => new Square(side);
        act.Should().Throw<ArgumentOutOfRangeException>().WithParameterName("side");
    }

    [Theory]
    [InlineData(0, 1, 1, "a")]
    [InlineData(1, -1, 1, "b")]
    [InlineData(1, 1, 0, "c")]
    public void Triangle_InvalidSide_Throws(double a, double b, double c, string paramName)
    {
        Action act = () => new Triangle(a, b, c);
        act.Should().Throw<ArgumentOutOfRangeException>().WithParameterName(paramName);
    }

    [Fact]
    public void Polymorphism_Circle_AreaIsPositive()
    {
        var circle = new Circle(1);
        circle.CalculateArea().Should().BeGreaterThan(0);
    }

    [Fact]
    public void Polymorphism_Circle_PerimeterIsPositive()
    {
        var circle = new Circle(1);
        circle.CalculatePerimeter().Should().BeGreaterThan(0);
    }

    [Fact]
    public void Polymorphism_Circle_ToStringContainsShape()
    {
        var circle = new Circle(1);
        circle.ToString().IndexOf("Shape:", StringComparison.OrdinalIgnoreCase).Should().BeGreaterThan(-1);
    }

    [Fact]
    public void Polymorphism_Rectangle_AreaIsPositive()
    {
        var rectangle = new Rectangle(2, 3);
        rectangle.CalculateArea().Should().BeGreaterThan(0);
    }

    [Fact]
    public void Polymorphism_Rectangle_PerimeterIsPositive()
    {
        var rectangle = new Rectangle(2, 3);
        rectangle.CalculatePerimeter().Should().BeGreaterThan(0);
    }

    [Fact]
    public void Polymorphism_Rectangle_ToStringContainsShape()
    {
        var rectangle = new Rectangle(2, 3);
        rectangle.ToString().IndexOf("Shape:", StringComparison.OrdinalIgnoreCase).Should().BeGreaterThan(-1);
    }

    [Fact]
    public void Polymorphism_Square_AreaIsPositive()
    {
        var square = new Square(4);
        square.CalculateArea().Should().BeGreaterThan(0);
    }

    [Fact]
    public void Polymorphism_Square_PerimeterIsPositive()
    {
        var square = new Square(4);
        square.CalculatePerimeter().Should().BeGreaterThan(0);
    }

    [Fact]
    public void Polymorphism_Square_ToStringContainsShape()
    {
        var square = new Square(4);
        square.ToString().IndexOf("Shape:", StringComparison.OrdinalIgnoreCase).Should().BeGreaterThan(-1);
    }

    [Fact]
    public void Polymorphism_Triangle_AreaIsPositive()
    {
        var triangle = new Triangle(3, 4, 5);
        triangle.CalculateArea().Should().BeGreaterThan(0);
    }

    [Fact]
    public void Polymorphism_Triangle_PerimeterIsPositive()
    {
        var triangle = new Triangle(3, 4, 5);
        triangle.CalculatePerimeter().Should().BeGreaterThan(0);
    }

    [Fact]
    public void Polymorphism_Triangle_ToStringContainsShape()
    {
        var triangle = new Triangle(3, 4, 5);
        triangle.ToString().IndexOf("Shape:", StringComparison.OrdinalIgnoreCase).Should().BeGreaterThan(-1);
    }
}