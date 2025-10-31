namespace Labb_3_polymorphism_Daniel_Nilsson_SUT25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Circle circle = new Circle(2);
            Geometry square = new Square(2);
            Geometry rectangle = new Rectangle(2,3);

            Console.WriteLine("Cirkel: " + circle.Area());
            Console.WriteLine("Kvadrat: " + square.Area());
            Console.WriteLine("Rektangel: " + rectangle.Area());
            
        }

    }
}
