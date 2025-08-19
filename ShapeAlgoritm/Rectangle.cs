// <copyright file="Rectangle.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ShapeAlgoritm;
internal sealed class Rectangle : Shape
{
    private readonly double width;
    private readonly double height;

    public Rectangle(double width, double height)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(width);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(height);

        this.width = width;
        this.height = height;
    }

    public override double CalculateArea() => this.width * this.height;

    public override double CalculatePerimeter() => 2 * (this.width + this.height);

    public override string ToString() =>
        $$"""
          Shape: Rectangle
          Width: {{this.width}}, Height: {{this.height}}
          Perimeter: {{this.CalculatePerimeter():F2}}
          Area: {{this.CalculateArea():F2}}
          """;
}