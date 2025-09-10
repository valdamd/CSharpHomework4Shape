namespace ShapeAlgorithm;

internal sealed class Circle : Shape
{
    private readonly double _radius;

    public Circle(double radius)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(radius);
        this._radius = radius;
    }

    public override double CalculateArea() => Math.PI * _radius * _radius;

    public override double CalculatePerimeter() => 2 * Math.PI * _radius;

    public override string ToString() =>
        $$"""
          Shape: Circle
          Radius: {{_radius}}
          Perimeter: {{CalculatePerimeter():F2}}
          Area: {{CalculateArea():F2}}
          """;
}