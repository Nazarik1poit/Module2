Square square = new(5);
Rectangle rectangle = new(6, 3);
Console.WriteLine($"Площадь квадрата: {square.Area}, периметр: {square.Perimeter}");
Console.WriteLine($"Площадь прямоугольника: {rectangle.Area}, периметр: {rectangle.Perimeter}");

public abstract class Shape
{
    public abstract int Area { get; }
    public abstract int Perimeter { get; }
}

public class Square : Shape
{
    private int side;

    public Square(int side)
    {
        this.side = side;
    }

    public override int Area
    {
        get { return side * side; }
    }

    public override int Perimeter
    {
        get { return 4 * side; }
    }
}

public class Rectangle : Shape
{
    private int width;
    private int height;

    public Rectangle(int width, int height)
    {
        this.width = width;
        this.height = height;
    }

    public override int Area
    {
        get { return width * height; }
    }

    public override int Perimeter
    {
        get { return 2 * (width + height); }
    }
}
