using AreasLib.Figures;
using AreasLib.Figures.Implementations;
using Xunit;

namespace AreasLib.Tests;

public class AreasTests {
    [Fact]
    public void Cirlce_Area() {
        var circle = new Circle(5);

        var area = circle.GetArea();

        Assert.Equal(78.5398163397, area, 1e-10);
    }

    [Fact]
    public void Triangle_Area() {
        var triangle = new Triangle(1, 2, 2);

        var area = triangle.GetArea();

        Assert.Equal(0.9682458365, area, 1e-10);
    }

    [Fact]
    public void Figures_Areas() {
        var triangle = new Triangle(1, 2, 2);

        List<IFigure> figures = [
            new Triangle(3, 4, 5),
            new Circle(2),
            new Circle(1),
            new Triangle(0, 0, 0),
        ];

        var areas = figures.Select(figure => figure.GetArea()).ToList();

        Assert.Equal(6, areas[0], 1e-10);
        Assert.Equal(12.566370614359, areas[1], 1e-10);
        Assert.Equal(Math.PI, areas[2], 1e-10);
        Assert.Equal(0, areas[3], 1e-10);
    }
}
