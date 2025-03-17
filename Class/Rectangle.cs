namespace IceTask3.Class
{
    public class Rectangle : Shape, ICalculateArea
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width, string name) : base(name)
        {
            Length = length;
            Width = width;
        }

        double ICalculateArea.CalculateArea()
        {
            return Length * Width;
        }

        public override void Display()
        {
            //base.Display();
            Console.WriteLine($"Length: {Length}");
            Console.WriteLine($"Width: {Width}");
            Console.WriteLine($"Area: {((ICalculateArea)this).CalculateArea()}");
        }
    }
}
