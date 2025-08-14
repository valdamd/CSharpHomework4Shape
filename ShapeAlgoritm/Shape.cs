// <copyright file="Shape.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ShapeAlgoritm;
public abstract class Shape
{
   public abstract double CalculateArea();

   public abstract double CalculatePerimeter();

   public override string ToString() =>
       $"""
        Shape: {this.GetType().Name}
        Area: {this.CalculateArea():F2}
        Perimeter: {this.CalculatePerimeter():F2}
        """;
}