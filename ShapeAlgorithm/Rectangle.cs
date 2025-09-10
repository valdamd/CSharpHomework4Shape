namespace ShapeAlgorithm;

internal sealed class Rectangle : Shape
{
    private readonly double _width;
    private readonly double _height;

    public Rectangle(double width, double height)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(width);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(height);

        this._width = width;
        this._height = height;
    }

    public override double CalculateArea() => _width * _height;

    public override double CalculatePerimeter() => 2 * (_width + _height);

    public override string ToString() =>
        $$"""
          Shape: Rectangle
          Width: {{_width}}, Height: {{_height}}
          Perimeter: {{CalculatePerimeter():F2}}
          Area: {{CalculateArea():F2}}
          """;
}