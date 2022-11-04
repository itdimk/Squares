namespace Squares.Shapes;

public class Circle : Shape
{
    public float Radius { get; }
    public float Diameter => Radius * 2;

    public Circle(float radius)
    {
        if (radius < 0)
            throw new ArgumentOutOfRangeException($"{nameof(radius)} must be more or equal zero");
        Radius = radius;
    }

    public override float GetSquare()
    {
        return MathF.PI * Radius * Radius;
    }
}