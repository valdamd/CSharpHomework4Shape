// <copyright file="Circle.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ShapeAlgoritm;
public sealed class Circle : Shape
{
    private readonly double radius;

    public Circle(double radius)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(radius);
        this.radius = radius;
    }

    public override double CalculateArea() => Math.PI * this.radius * this.radius;

    public override double CalculatePerimeter() => 2 * Math.PI * this.radius;

    public override string ToString() =>
        $$"""
          Shape: Circle
          Radius: {{this.radius}}
          Perimeter: {{this.CalculatePerimeter():F2}}
          Area: {{this.CalculateArea():F2}}
          """;
}