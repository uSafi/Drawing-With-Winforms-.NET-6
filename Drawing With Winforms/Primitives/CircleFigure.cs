using System.Drawing.Drawing2D;

namespace Drawing_With_Winforms.Primitives
{
    internal class CircleFigure : IShape
    {
        public List<Point> Points { get; set; } = new List<Point>();
        public int MaxPoints { get; private set; } = 2;
        public Point Location { get; set; }
        public Size Size { get; private set; }
        public Pen Pen { get; set; }
        public Color? Fill { get; set; }
        public GraphicsPath Path { get; set; } = new GraphicsPath();

        public CircleFigure(Pen pen, Color? fill = null)
        {
            Pen = pen;
            Fill = fill;
        }
        private void SetValues()
        {
            InitiSize();
            InitiLocation();
        }

        private void InitiLocation()
        {
            var Point1 = Points[0];
            var Point2 = Points[1];
            int dX = Point1.X <= Point2.X ? Point1.X : Point2.X;
            int dY = Point1.Y <= Point2.Y ? Point1.Y : Point2.Y;
            Location = new Point(dX, dY);
        }

        private void InitiSize()
        {
            var Point1 = Points[0];
            var Point2 = Points[1];
            var dX = Math.Abs(Point1.X - Point2.X);
            var dY = Math.Abs(Point1.Y - Point2.Y);
            Size = new Size(dX, dY);
        }
        public void Draw(Graphics g)
        {
            SetValues();
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(new Rectangle(Location, Size));

            if (Fill is not null) g.FillPath(new SolidBrush(Fill.Value), grPath);
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
