namespace OCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AreaCalculator areaCalculator = new AreaCalculator();

            Console.WriteLine(areaCalculator.Area(new Circle { Radius=3}));
            Console.WriteLine(areaCalculator.Area(new Rectangle { Height=20, Width=38}));
        }
    }
}