namespace Polymorphism
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Shape(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }
        public abstract void Draw();
        public void Copy()
        {
            Console.WriteLine("Copied shape into clipboard");
        }

    }
    public class Circle: Shape
    {
        public Circle(int width, int height): base(width, height){}
        public override void Draw()
        {
            Console.WriteLine("Draw a circle");
        }
    }
    public class Rectangle : Shape
    {
        public Rectangle(int width, int height): base(width, height){}
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle(100, 200);  
            circle.Draw();

            var rectangle = new Rectangle(200, 100);    
            rectangle.Draw();

        }
    }
}
