using System;

class Rectangle
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }
    public int GetRectangleArea()
    {
        return Width * Height;
    }
}
class Square : Rectangle
{
    public override int Width
    {
        get { return base.Width; }
        set
        {
            base.Height = value;
            base.Width = value;
        }
    }
    public override int Height
    {
        get { return base.Height; }
        set
        {
            base.Height = base.Width;
            base.Width = base.Width;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Square();
            rect.Width = 5;
            Console.WriteLine(rect.GetRectangleArea());
            Console.ReadKey();
        }
    }
}