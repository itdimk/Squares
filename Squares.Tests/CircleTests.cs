using Squares.Shapes;

namespace Squares.Tests;

[TestClass]
public class CircleTests
{
    [TestMethod]
    public void TestSquare1()
    {
        Shape shape = new Circle(1f);
        float result = shape.GetSquare();
        float error = Math.Abs(result - MathF.PI);
        Assert.IsTrue(error <= float.Epsilon);
    }


    [TestMethod]
    public void TestSquare2()
    {
        Shape shape = new Circle(0f);
        float result = shape.GetSquare();
        float error = Math.Abs(result);
        Assert.IsTrue(error <= float.Epsilon);
    }

    [TestMethod]
    public void TestSquare3()
    {
        Shape shape = new Circle(10f);
        float result = shape.GetSquare();
        float error = Math.Abs(result - MathF.PI * 100);
        Assert.IsTrue(error <= float.Epsilon);
    }

    [TestMethod]
    public void TestDiameter()
    {
        Circle circle = new Circle(1);
        float error = MathF.Abs(circle.Diameter - 2);
        Assert.IsTrue(error <= float.Epsilon);
    }
}