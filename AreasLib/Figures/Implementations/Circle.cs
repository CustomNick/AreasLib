namespace AreasLib.Figures.Implementations;

public class Circle : IFigure {
    private readonly double radius;

    public Circle(double r) {
        ArgumentOutOfRangeException.ThrowIfLessThan(r, 0.0);
        radius = r;
    }

    public double GetArea() {
        return Math.PI * radius * radius;
    }
}
