namespace AreasLib.Figures.Implementations;

public class Triangle : IFigure {
    private readonly double[] sides;
    private bool sidesSorted;

    public Triangle(double x, double y, double z) {
        ArgumentOutOfRangeException.ThrowIfLessThan(x, 0.0);
        ArgumentOutOfRangeException.ThrowIfLessThan(y, 0.0);
        ArgumentOutOfRangeException.ThrowIfLessThan(z, 0.0);

        if (x + y < z || y + z < x || x + z < y) {
            throw new ArgumentException("Invalid triangle sides provided");
        }

        sides = [x, y, z];
        sidesSorted = x <= y && y <= z;
    }

    public double GetArea() {
        return Math.Sqrt(
            (sides[0] + sides[1] + sides[2])
            * (sides[0] + sides[1] - sides[2])
            * (sides[1] + sides[2] - sides[0])
            * (sides[0] + sides[2] - sides[1])
        ) / 4;
    }

    public bool IsRight() {
        if (!sidesSorted) {
            Array.Sort(sides);
            sidesSorted = true;
        }

        return sides[0] * sides[0] + sides[1] * sides[1] - sides[2] * sides[2] == 0;
    }
}
