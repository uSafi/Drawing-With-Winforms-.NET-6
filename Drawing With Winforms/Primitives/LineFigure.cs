using System.Drawing.Drawing2D;

namespace Drawing_With_Winforms.Primitives
{
    internal class LineFigure : IShape
    {
        public List<Point> Points { get; set; } = new List<Point>();
        public int MaxPoints { get; private set; } = 2;
        public Point Location { get; set; }
        public Size Size { get; private set; }
        public Pen Pen { get; set; }
        public Color? Fill { get; set; }
        public GraphicsPath Path { get; set; } = new GraphicsPath();

        

        public LineFigure(Pen pen, Color? fill = null)
        {
            Pen = pen;
            Fill = fill;
        }
        public void Draw(Graphics g)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddLine(Points[0], Points[1]);
            g.DrawPath(Pen, grPath);
            Path = grPath;
        }

        public void Move(Point e)
        {
            var Point1 = Points[0];
            var Point2 = Points[1];

            Point1.Offset(e.X, e.Y);
            Point2.Offset(e.X, e.Y);
            Points[0] = Point1;
            Points[1] = Point2;
        }
    }
}
