namespace Squares.Shapes;

public class Triangle : Shape
{
    public float A { get; }
    public float B { get; }
    public float C { get; }


    public Triangle(float a, float b, float c)
    {
        if (!CheckExisting(a, b, c))
            throw new ArgumentException($"Triangle with a={a}, b={b}, c={c} couldn't exist");
        A = a;
        B = b;
        C = c;
    }

    // Checks if triangle with a,b,c could exist
    // Each side should be shorter then sum of other 2
    private bool CheckExisting(float a, float b, float c)
    {
        return a <= b + c && b <= a + c && c <= a + b;
    }

    public override float GetSquare()
    {
        float p = (A + B + C) / 2f;
        return MathF.Sqrt(p * (p - A) * (p - B) * (p - C));
    }

    public bool IsRectangular()
    {
        float a = A;
        float b = B;
        float c = C;

        if (a < b)
            (a, b) = (b, a);
        if (a < c)
            (a, c) = (c, a);
        if (b < c)
            (b, c) = (c, b);

        float delta = MathF.Abs(a * a - (b * b + c * c));
        return delta <= 1E-6;
    }
}