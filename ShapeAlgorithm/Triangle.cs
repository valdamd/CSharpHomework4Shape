using ShapeAlgorithm;

namespace ShapeAlgotithm;

internal sealed class Triangle : Shape
{
    private readonly double _a;
    private readonly double _b;
    private readonly double _c;

    public Triangle(double a, double b, double c)
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(a);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(b);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(c);

        this._a = a;
        this._b = b;
        this._c = c;
    }

    public override double CalculateArea()
    {
        var s = (_a + _b + _c) / 2;
        return Math.Sqrt(s * (s - _a) * (s - _b) * (s - _c));
    }

    public override double CalculatePerimeter() => _a + _b + _c;

    public override string ToString() =>
        $$"""
          Shape: Triangle
          Sides: {{_a}}, {{_b}}, {{_c}}
          Perimeter: {{CalculatePerimeter():F2}}
          Area: {{CalculateArea():F2}}
          """;
}