namespace ShapeAlgorithm;
internal sealed class Square : Shape
{
    private readonly double _side;

    public Square(double side)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(side);

        this._side = side;
    }

    public override double CalculateArea() => _side * _side;

    public override double CalculatePerimeter() => 4 * _side;

    public override string ToString() =>
        $$"""
          Shape: Square
          Side: {{_side}}
          Perimeter: {{CalculatePerimeter():F2}}
          Area: {{CalculateArea():F2}}
          """;
}