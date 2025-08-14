// <copyright file="Square.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ShapeAlgoritm;
public sealed class Square : Shape
{
    private readonly double side;

    public Square(double side)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(side);

        this.side = side;
    }

    public override double CalculateArea() => this.side * this.side;

    public override double CalculatePerimeter() => 4 * this.side;

    public override string ToString() =>
        $$"""
          Shape: Square
          Side: {{this.side}}
          Perimeter: {{this.CalculatePerimeter():F2}}
          Area: {{this.CalculateArea():F2}}
          """;
}