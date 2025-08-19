// <copyright file="Triangle.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ShapeAlgotitm;

using ShapeAlgoritm;

internal sealed class Triangle : Shape
{
    private readonly double a;
    private readonly double b;
    private readonly double c;

    public Triangle(double a, double b, double c)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(a);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(b);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(c);
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public override double CalculateArea()
    {
        double s = (this.a + this.b + this.c) / 2;
        return Math.Sqrt(s * (s - this.a) * (s - this.b) * (s - this.c));
    }

    public override double CalculatePerimeter() => this.a + this.b + this.c;

    public override string ToString() =>
        $$"""
          Shape: Triangle
          Sides: {{this.a}}, {{this.b}}, {{this.c}}
          Perimeter: {{this.CalculatePerimeter():F2}}
          Area: {{this.CalculateArea():F2}}
          """;
}