using AreasLib.Figures.Implementations;
using Xunit;

namespace AreasLib.Tests;

public class FiguresTests {
    [Fact]
    public void Cirlce_Invalid_Radius() {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-5));
    }

    [Fact]
    public void Triangle_Negative_First_Side() {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, 2, 3));
    }

    [Fact]
    public void Triangle_Negative_Second_Side() {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, -2, 3));
    }

    [Fact]
    public void Triangle_Negative_Third_Side() {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, 2, -3));
    }

    [Fact]
    public void Triangle_Invalid_Sides() {
        Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 4));
    }

    [Fact]
    public void Triangle_Is_Right_True() {
        var triangle = new Triangle(3, 5, 4);

        Assert.True(triangle.IsRight());
    }

    [Fact]
    public void Triangle_Is_Right_False() {
        var triangle = new Triangle(3, 4, 6);

        Assert.False(triangle.IsRight());
    }
}
