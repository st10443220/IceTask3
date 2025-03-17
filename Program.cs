using IceTask3.Class;

namespace IceTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new(6, "Circle");
            Rectangle rectangle = new(13, 2, "Rectangle");

            // Circle
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(circle.GetType().ToString().Split(".").Last());
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            circle.Display();
            Console.ResetColor();

            // New line
            Console.WriteLine();

            // Rectangle
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(rectangle.GetType().ToString().Split(".").Last());
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            rectangle.Display();
            Console.ResetColor();
        }
    }
}
