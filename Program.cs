namespace Labb_3_polymorphism_Daniel_Nilsson_SUT25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Geometry circle = new Circle();
            Geometry square = new Square();
            Geometry rectangle = new Rectangle();

            List<Geometry> shapeslist = new List<Geometry> { circle, square, rectangle };

            
            foreach (var item in shapeslist)
            {
                Console.Write(item.Area()+"\n");
            }
            
        }

    }
}
