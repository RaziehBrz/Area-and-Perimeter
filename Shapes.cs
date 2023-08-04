abstract class Shape
{
    public double Area { get; set; }
    public double Perimeter { get; set; }
    public abstract void Calculator();
}
class Circle : Shape
{
    double radius;
    public override void Calculator()
    {
        Console.WriteLine("Enter the radius of circle : ");
        radius = Convert.ToDouble(Console.ReadLine());

        Area = radius * radius * Math.PI;
        Perimeter = radius * 2 * Math.PI;

        Console.WriteLine($"Area is {Area}");
        Console.WriteLine($"Perimeter is {Perimeter}");
    }
}
class Squer : Shape
{
    double side;
    public override void Calculator()
    {
        Console.WriteLine("Enter the side of squer : ");
        side = Convert.ToDouble(Console.ReadLine());

        Area = side * side;
        Perimeter = side * 4;

        Console.WriteLine($"Area is {Area}");
        Console.WriteLine($"Perimeter is {Perimeter}");
    }
}
class Rectangle : Shape
{
    double width;
    double height;
    public override void Calculator()
    {
        Console.WriteLine("Enter the Width of rectangle : ");
        height = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the height of rectangle : ");
        width = Convert.ToDouble(Console.ReadLine());

        Area = width * height;
        Perimeter = 2 * (width + height);

        Console.WriteLine($"Area is {Area}");
        Console.WriteLine($"Perimeter is {Perimeter}");
    }
}
class Triangle : Shape
{
    double side;
    double height;
    public override void Calculator()
    {
        Console.WriteLine("Enter the side of triangle : ");
        side = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the Height of triangle : ");
        height = Convert.ToDouble(Console.ReadLine());

        Area = (height * side) / 2;
        Perimeter = side * 4;

        Console.WriteLine($"Area is {Area}");
        Console.WriteLine($"Perimeter is {Perimeter}");
    }
}