namespace CS10;

public record struct Point {
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; init; }

    internal void Deconstruct(out double x, out double y)
    {
        x = X;
        y = Y;
    }
}
