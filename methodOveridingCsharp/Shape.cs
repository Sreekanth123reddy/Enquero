namespace methodOveridingCsharp
{
    public class Rectangle : Shape
    {
        public override void Draw()
        {
           System.Console.WriteLine("Draw Rectangle");
        }

    }
    public class Traingle : Shape
    {
        public override void Draw()
        {
            System.Console.WriteLine("Draw Traingle");
        }
    }
    public class Circle : Shape
    {
        public override void Draw()
        {
            System.Console.WriteLine( "Draw Circle");
                
        }
    }
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public virtual void Draw()
        {

        }
    }
}
