using System.Drawing.Drawing2D;

namespace Drawing_With_Winforms.Primitives
{
    internal interface IShape
    {
        List<Point> Points { get; set; }
        int MaxPoints { get; }
        Point Location { get; set; }
        GraphicsPath Path { get; set; }  
        Pen Pen { get; set; }
        Color? Fill { get; set; }
        Size Size { get; }
        void Draw(Graphics g);
        void Move(Point d);
    }
}