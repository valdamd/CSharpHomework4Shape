namespace ShapeAlgorithm;
public abstract class Shape
{
   public abstract double CalculateArea();

   public abstract double CalculatePerimeter();

   public override string ToString() =>
       $"""
        Shape: {GetType().Name}
        Area: {CalculateArea():F2}
        Perimeter: {CalculatePerimeter():F2}
        """;
}