using System;

class Point
{
    public double X { get; set; }
    public double Y { get; set; }

    public Point(double x, double y) { X = x; Y = y; }

    public static Point operator +(Point a, Point b) => new Point(a.X + b.X, a.Y + b.Y);
    public static Point operator *(Point p, double k) => new Point(p.X * k, p.Y * k); // домашнє
    public static Point operator *(double k, Point p) => p * k;

    public static bool operator ==(Point a, Point b)
    {
        if (ReferenceEquals(a, b)) return true;
        if (a is null || b is null) return false;
        return a.X == b.X && a.Y == b.Y;
    }
    public static bool operator !=(Point a, Point b) => !(a == b);

    public override bool Equals(object obj) => obj is Point p && this == p;
    public override int GetHashCode() => HashCode.Combine(X, Y);
    public override string ToString() => $"({X}; {Y})";
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Point a = new Point(1, 2);
        Point b = new Point(3, 4);
        Point c = new Point(1, 2);

        Console.WriteLine($"a + b = {a + b}");
        Console.WriteLine($"a == c: {a == c}");
        Console.WriteLine($"a != b: {a != b}");
        Console.WriteLine($"a * 3 = {a * 3}");
        Console.WriteLine($"2 * b = {2 * b}");
    }
}
