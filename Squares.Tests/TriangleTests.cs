using Squares.Shapes;

namespace Squares.Tests;

[TestClass]
public class TriangleTests
{
    public void TestExisting1()
    {
        Assert.ThrowsException<ArgumentException>(() => new Triangle(1, 1, 3));
    }

    public void TestExisting2()
    {
        var shape = new Triangle(1, 1, 2); // Shouldn't throw error
        Assert.IsNotNull(shape);
    }

    [TestMethod]
    public void TestIsRectangular1()
    {
        var triangle = new Triangle(1, 1, MathF.Sqrt(2));
        Assert.IsTrue(triangle.IsRectangular());
    }


    [TestMethod]
    public void TestIsRectangular2()
    {
        var triangle = new Triangle(9, 4, 5);
        Assert.IsFalse(triangle.IsRectangular());
    }


    [TestMethod]
    public void TestSquare1()
    {
        Shape shape = new Triangle(1, 1, 1);
        float square = shape.GetSquare();
        float error = MathF.Abs(square - 0.433013f);

        Assert.IsTrue(error <= 1E-6f);
    }

    [TestMethod]
    public void TestSquare2()
    {
        Shape shape = new Triangle(1, 1, 2);
        float square = shape.GetSquare();

        Assert.IsTrue(square <= float.Epsilon);
    }

    [TestMethod]
    public void TestSquare3()
    {
        Shape shape = new Triangle(1, 2, 2.5f);
        float square = shape.GetSquare();
        float error = MathF.Abs(square - 0.949918f);

        Assert.IsTrue(error <= 1E-6f);
    }
}