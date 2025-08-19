// <copyright file="ShapeTest.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TestShape;

using FluentAssertions;
using ShapeAlgoritm;
using ShapeAlgotitm;
using Xunit;

public sealed class ShapeTest
{
    [Fact]
    public void Circle_CorrectAreaAndPerimeter()
    {
        var circle = new Circle(2);

        circle.CalculateArea().Should().BeApproximately(Math.PI * 4, 0.001);
        circle.CalculatePerimeter().Should().BeApproximately(2 * Math.PI * 2, 0.001);
    }

    [Fact]
    public void Rectangle_CorrectAreaAndPerimeter()
    {
        var rect = new Rectangle(4, 5);

        rect.CalculateArea().Should().Be(20);
        rect.CalculatePerimeter().Should().Be(18);
    }

    [Fact]
    public void Square_CorrectAreaAndPerimeter()
    {
        var square = new Square(3);

        square.CalculateArea().Should().Be(9);
        square.CalculatePerimeter().Should().Be(12);
    }

    [Fact]
    public void Triangle_CorrectAreaAndPerimeter()
    {
        var triangle = new Triangle(3, 4, 5);

        triangle.CalculateArea().Should().BeApproximately(6, 0.01);
        triangle.CalculatePerimeter().Should().Be(12);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-5)]
    public void Circle_InvalidRadius_Throws(double radius)
    {
        Action act = () => new Circle(radius);

        act.Should()
           .Throw<ArgumentOutOfRangeException>()
           .WithParameterName("radius");
    }

    [Theory]
    [InlineData(0, 5)]
    [InlineData(5, -2)]
    public void Rectangle_InvalidDimensions_Throw(double width, double height)
    {
        Action act = () => new Rectangle(width, height);

        act.Should()
           .Throw<ArgumentOutOfRangeException>()
           .Where(e => e.ParamName == "width" || e.ParamName == "height");
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void Square_InvalidSide_Throws(double side)
    {
        Action act = () => new Square(side);

        act.Should()
           .Throw<ArgumentOutOfRangeException>()
           .WithParameterName("side");
    }

    [Theory]
    [InlineData(0, 1, 2)]
    [InlineData(1, -1, 1)]
    public void Triangle_InvalidSides_Throws(double a, double b, double c)
    {
        if (a <= 0)
        {
            Action act = () => new Triangle(a, 1, 1);
            act.Should()
                .Throw<ArgumentOutOfRangeException>()
                .WithParameterName("a");
        }

        if (b <= 0)
        {
            Action act = () => new Triangle(1, b, 1);
            act.Should()
                .Throw<ArgumentOutOfRangeException>()
                .WithParameterName("b");
        }

        if (c <= 0)
        {
            Action act = () => new Triangle(1, 1, c);
            act.Should()
                .Throw<ArgumentOutOfRangeException>()
                .WithParameterName("c");
        }
    }

    [Fact]
    public void Polymorphism_WorksCorrectly()
    {
        Shape[] shapes =
        {
            new Circle(1),
            new Rectangle(2, 3),
            new Square(4),
            new Triangle(3, 4, 5),
        };

        foreach (var shape in shapes)
        {
            shape.CalculateArea().Should().BeGreaterThan(0);
            shape.CalculatePerimeter().Should().BeGreaterThan(0);
            shape.ToString().IndexOf("Shape:", StringComparison.OrdinalIgnoreCase).Should().BeGreaterThan(-1);
        }
    }
}
