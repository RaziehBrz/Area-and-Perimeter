internal class Program
{
    private static void Main(string[] args)
    {
        var circle = new Circle();
        var squer = new Squer();
        var rectangle = new Rectangle();
        var triangle = new Triangle();

        var shapes = new Shape[]
        {
            circle , squer , rectangle , triangle
        };

        var Exit = false;
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("Welcome ^-^");
        Console.ResetColor();
        Console.WriteLine("This program calculates the perimeter and area of some shapes \nPress Enter to display the menu \n");
        Console.ReadLine();

        while (!Exit)
        {
            PrintMenu();
            var inputNumber = Console.ReadLine();
            Console.Clear();
            SetShapeNumber(inputNumber, shapes);

            Console.ReadLine();
            Console.Clear();
        }
    }
    static void SetShapeNumber(string inputNumber, Shape[] shapes)
    {
        switch (inputNumber)
        {
            case "1":
                shapes[0].Calculator();
                break;
            case "2":
                shapes[1].Calculator();
                break;
            case "3":
                shapes[2].Calculator();
                break;
            case "4":
                shapes[3].Calculator();
                break;
            case "5":
                Console.WriteLine("Good bye :)");
                Environment.Exit(0);
                break;
            default:
                throw new Exception("That was not a valid optin");
        }
    }
    static void PrintMenu()
    {
        Console.WriteLine("Shapes : ");
        Console.WriteLine("1) Circle ");
        Console.WriteLine("2) Squer ");
        Console.WriteLine("3) Rectangle ");
        Console.WriteLine("4) Triangle (Equilateral)");
        Console.WriteLine("5) Exit");
    }
}
