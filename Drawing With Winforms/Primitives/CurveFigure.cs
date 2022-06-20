using System.Drawing.Drawing2D;

namespace Drawing_With_Winforms.Primitives
{
    internal class CurveFigure : IShape
    {
        public List<Point> Points { get; set; } = new List<Point>();
        public int MaxPoints { get; private set; } = 3;
        public Point Location { get; set; }
        public Size Size { get; private set; }
        public Pen Pen { get; set; }
        public Color? Fill { get; set; }
        public GraphicsPath Path { get; set; } = new GraphicsPath();

        public CurveFigure(Pen pen, Color? fill = null)
        {
            Pen = pen;
            Fill = fill;
        }
        public void Draw(Graphics g)
        {
            GraphicsPath grPath = new GraphicsPath();
            if (Points.Count() == 2)
                grPath.AddLine(Points[0], Points[1]);
            else
                grPath.AddCurve(Points.ToArray());

            if (Fill is not null) g.FillPath(new SolidBrush(Fill.Value), grPath);
            g.DrawPath(Pen, grPath);
            Path = grPath;
        }

        public void Move(Point e)
        {
            for (int i = 0; i < Points.Count; i++)
            {
                Points[i] = new Point(Points[i].X + e.X, Points[i].Y + e.Y);
            }
        }
    }
}
