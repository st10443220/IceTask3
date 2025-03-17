namespace IceTask3.Class
{
    public class Circle : Shape, ICalculateArea
    {
        public double Radius { get; set; }

        public Circle(double radius, string name) : base(name)
        {
            Radius = radius;
        }

        double ICalculateArea.CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override void Display()
        {
            //base.Display();
            Console.WriteLine($"Radius: {Radius}");
            Console.WriteLine($"Area: {((ICalculateArea)this).CalculateArea()}");
        }
    }
}
