Random rnd = new Random();
Circle[] circles = new Circle[4];
Rectangle[] rects = new Rectangle[4];
Triangle[] triangles = new Triangle[4];
for (int i = 0; i < 4; i++)
{
    circles[i] = new(rnd.Next(1,35));
    circles[i].Draw();
    rects[i] = new(rnd.Next(5, 15), rnd.Next(6, 15));
    rects[i].Draw();
    triangles[i] = new(rnd.Next(7, 15));
    triangles[i].Draw();
}

public interface IDrawable
{
    public void Draw();
}

public class Circle: IDrawable
{
    private int radius;
    public void Draw()
    {
        Console.WriteLine($"Вы нарисовали круг, радиус - {this.radius}");
    }

    public Circle(int radius)
    {
        this.radius = radius;
    }
}

public class Rectangle: IDrawable
{
    private int height;
    private int width;
    public void Draw()
    {
        Console.WriteLine($"Вы нарисовали прямоугольник, ширина - {this.width}, высота - {this.height}");
    }
    
    public Rectangle(int height, int width)
    {
        this.height = height;
        this.width = width;
    }
}

public class Triangle : IDrawable
{
    int perimeter;
    public void Draw()
    {
        Console.WriteLine($"Вы нарисовали треугольник, периметр: {this.perimeter}");
    }
    public Triangle(int perimeter)
    {
        this.perimeter = perimeter;
    }
}