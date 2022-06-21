using Drawing_With_Winforms.Controls;
using Drawing_With_Winforms.Enums;
using Drawing_With_Winforms.Primitives;
using Drawing_With_Winforms.Properties;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Input;

namespace Drawing_With_Winforms
{
    public partial class Dashboard : Form
    {
        private Stack<IShape> Shapes = new Stack<IShape>();
        private Stack<IShape> UndoedShapes = new Stack<IShape>();
        private IShape NewShape;
        private bool StartInteractiveShape = false;
        private bool IsMouseDown = false;
        private Point DragStartPoint;
        private IShape? DragedShape = null;
        private bool DeleteKeyPressed;

        public Dashboard()
        {
            InitializeComponent();
            WindowState = (FormWindowState)Settings.Default.WindowState;
            btnStroke.BackColor = Settings.Default.StrokeColor;
            btnFill.BackColor = Settings.Default.FillColor;

            (Pen pen, Color? fill) = GetPenAndFill();
            NewShape = new LineFigure(pen, fill);

            chkCanUseFill.Checked = Settings.Default.CanUseFill;
            Canvas.BackColor = btnCanvasBackgroundColor.BackColor = Settings.Default.CanvasBackgroundColor;

            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(2, 2, rbtnCircle.Width - 5, rbtnCircle.Height - 5);
            rbtnCircle.Region = new Region(grPath);


            ShowCanvasSize();
        }
        private void btnStrokeColor_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            colorDialog.Color = btnStroke.BackColor;
            if (DialogResult.OK == colorDialog.ShowDialog())
            {
                btnStroke.BackColor = colorDialog.Color;
                NewShape.Pen = GetPenAndFill().pen;
            }
        }
        private void chkCanUseFill_CheckedChanged(object sender, EventArgs e)
        {
            btnFill.Enabled = chkCanUseFill.Checked;
            NewShape.Fill = chkCanUseFill.Checked != false ? btnFill.BackColor : null;
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            colorDialog.Color = btnFill.BackColor;
            if (DialogResult.OK == colorDialog.ShowDialog())
            {
                btnFill.BackColor = colorDialog.Color;
                NewShape.Fill = btnFill.BackColor;
            }
        }
        private void Canvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) return;
            if (chkInteractiveMode.Checked || IsMouseDown) return;
            int x = e.X;
            int y = e.Y;

            NewShape.Points.Add(new Point(x, y));
            if (NewShape.Points.Count == NewShape.MaxPoints)
            {
                AddRigidShape();
            }
            else if (chkContinuousDrawing.CheckState == CheckState.Checked && chkContinuousDrawing.Enabled && Shapes.Count != 0)
            {
                var lastShape = Shapes.Peek();
                var lastShapePoint = lastShape.Points.TakeLast(1);
                var theNewPoint = NewShape.Points[NewShape.Points.Count - 1];
                NewShape.Points[0] = lastShapePoint.First();
                NewShape.Points.Add(theNewPoint);
                if (NewShape.Points.Count == NewShape.MaxPoints)
                    AddRigidShape();
            }
            else
            {
                drawPoint(x, y);
            }

        }
        public void drawPoint(int x, int y)
        {
            Graphics g = Canvas.CreateGraphics();
            var color = btnStroke.BackColor;
            SolidBrush brush = new SolidBrush(color);
            Point dPoint = new Point(x, y);
            dPoint.X -= 2;
            dPoint.Y -= 2;
            Rectangle rect = new Rectangle(dPoint, new Size(4, 4));
            g.FillRectangle(brush, rect);
        }
        private void SharedShapesButtons_CheckedChanged(object sender, EventArgs e)
        {
            NewShape = CreateShape();
        }
        private void tbStrokeThickness_Scroll(object sender, EventArgs e)
        {
            NewShape.Pen = GetPenAndFill().pen;
        }
        private (Pen pen, Color? fill) GetPenAndFill()
        {
            
            var thickness = tbStrokeThickness.Value;
            var pen = new Pen(btnStroke.BackColor, thickness);           
            Color? fill = chkCanUseFill.Checked == true ? btnFill.BackColor: null;
            return (pen, fill);
        }
        private IShape CreateShape()
        {
            (Pen pen, Color? fill) = GetPenAndFill();
            ShapeType selectedType = ShapeType.Line;
            foreach (ShapeRadioButton control in flpFiguresContainer.Controls)
            {
                if (control.Checked)
                {
                    selectedType = control.ShapeType;
                    break;
                }
            }
            switch (selectedType)
            {
                case ShapeType.Line:
                    return new LineFigure(pen, fill);
                case ShapeType.Rectangle:
                    return new RectangleFigure(pen, fill);
                case ShapeType.Circle:
                    return new CircleFigure(pen, fill);
                case ShapeType.Curve:
                    return new CurveFigure(pen, fill);
                default:
                    return new LineFigure(pen, fill);
            }
        }
        private void AddRigidShape()
        {
            PushShape(NewShape);
            Canvas.Invalidate();
        }

        private void PushShape(IShape shape)
        {
            Shapes.Push(shape);
            btnUndo.Enabled = true;
        }
        private void PopShape()
        {
            if (Shapes.Count != 0)
            {
                Shapes.Pop();
            }
            if (Shapes.Count == 0)
            {
                btnUndo.Enabled = false;
            }
        }
        private void ClearShapes()
        {
            Shapes.Clear();
            UndoedShapes.Clear();
            btnUndo.Enabled = false;
            btnRedo.Enabled = false;
            Canvas.Invalidate();
        }
        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (Shapes.Count != 0)
            {
                UndoedShapes.Push(Shapes.Peek());
                btnRedo.Enabled = true;
                PopShape();
                Canvas.Invalidate();
            }
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            if (UndoedShapes.Count != 0)
            {
                var shape = UndoedShapes.Pop();
                PushShape(shape);

                if (UndoedShapes.Count == 0)
                    btnRedo.Enabled = false;

                Canvas.Invalidate();
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearShapes();
        }
        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            if (Shapes.Count != 0)
            {
                var g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                IEnumerable<IShape> DrawnObjects;
                if (chkReverseOrder.Checked)
                    DrawnObjects = Shapes;
                else
                {
                    DrawnObjects = Shapes.Reverse();
                }
                foreach (var shape in DrawnObjects)
                {
                    shape.Draw(g);
                }
            }
        }

        // -------------------------- Interactive Drawing -----------------------
        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (!chkInteractiveMode.Checked) return;
            if (e.Button == MouseButtons.Right) return;
            if (e.Button == MouseButtons.Left && ModifierKeys == Keys.Control) return;

            NewShape.Points.Add(new Point(e.X, e.Y));

            IsMouseDown = true;
        }


        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            lblMousePosition.Text = $"{e.X}, {e.Y}px";

            if (DragedShape is not null)
            {
                DragShape(e);
                return;
            }

            DragStartPoint = e.Location;

            if (!StartInteractiveShape)
                DetectShape(e);

            ShowHideCanvasChangeColorButton(e);

            if (!chkInteractiveMode.Checked) return;
            if (e.Button == MouseButtons.Left && IsMouseDown)
            {
                int x = e.X;
                int y = e.Y;
                if (NewShape.Points.Count % 2 != 0 && NewShape.Points.Count != NewShape.MaxPoints)
                    NewShape.Points.Add(new Point(x, y));
                else if (NewShape.Points.Count > 1)
                    NewShape.Points[NewShape.Points.Count - 1] = new Point(x, y);

                if (Shapes.Count != 0 && StartInteractiveShape)
                {
                    PopShape();
                }

                StartInteractiveShape = true;

                PushShape(NewShape);
                Canvas.Invalidate();
            }
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            DragedShape = null;

            if (NewShape.Points.Count == NewShape.MaxPoints)
            {
                NewShape = CreateShape();
                StartInteractiveShape = false;
            }

            if (!chkInteractiveMode.Checked) return;         

            IsMouseDown = false;
            Canvas.Invalidate();

            UndoedShapes.Clear();
            btnRedo.Enabled = false;
        }
        // ------------------------------End Of Interactive Drawing----------------------


        // ------------------------------Start Of Moving Shapes-----------------------------
        private void DetectShape(MouseEventArgs e)
        {
            foreach (var shape in Shapes)
            {
                if (shape.Path is null) continue;
                if (shape.Path.IsOutlineVisible(e.Location, shape.Pen))
                {
                    Brush aGradientBrush = new LinearGradientBrush(new Point(0, 0), new Point(1, 2), shape.Pen.Color, Color.Silver);
                    shape.Pen.Brush = aGradientBrush;
                    Canvas.Invalidate();
                    if (e.Button == MouseButtons.Left && ModifierKeys == Keys.Control)
                    {
                        DragedShape = shape;
                        break;
                    }
                }
                else
                {
                    shape.Pen.Brush = new SolidBrush(shape.Pen.Color);
                    Canvas.Invalidate();
                }
            }
            if (DragedShape != null)
            {
                DragShape(e);
            }
        }

        private void DragShape(MouseEventArgs e)
        {
            var d = new Point(e.X - DragStartPoint.X, e.Y - DragStartPoint.Y);
            DragedShape?.Move(d);

            Canvas.Invalidate();
            DragStartPoint = e.Location;
        }
        private void btnCanvasBackgroundColor_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            colorDialog.Color = btnCanvasBackgroundColor.BackColor;
            if (DialogResult.OK == colorDialog.ShowDialog())
            {
                Canvas.BackColor = btnCanvasBackgroundColor.BackColor = colorDialog.Color;
            }
        }
        private void ShowHideCanvasChangeColorButton(MouseEventArgs e)
        {
            var lxy = new Point(pnlContainer.HorizontalScroll.Value, pnlContainer.VerticalScroll.Value);

            if ((new Rectangle(lxy, btnCanvasBackgroundColor.Size)).Contains(e.X, e.Y))
            {
                btnCanvasBackgroundColor.Location = default;
                btnCanvasBackgroundColor.Show();
            }
            else
            {
                btnCanvasBackgroundColor.Hide();
            }
            if ((new Rectangle(new Point(lxy.X, lxy.Y + btnCanvasBackgroundColor.Height), btnRemoveCanvasBackgroundImage.Size)).Contains(e.X, e.Y) && Canvas.Image != null)
            {
                btnRemoveCanvasBackgroundImage.Location = new Point(0, btnCanvasBackgroundColor.Height);
                btnRemoveCanvasBackgroundImage.Show();
            }
            else
            {
                btnRemoveCanvasBackgroundImage.Hide();
            }
        }
        private void btnRemoveCanvasBackgroundImage_Click(object sender, EventArgs e)
        {
            Canvas.Image = null;
            btnRemoveCanvasBackgroundImage.Hide();
        }
        private void chkReverseDrawing_CheckedChanged(object sender, EventArgs e)
        {
            Canvas.Invalidate();
        }
        private void chkInteractiveMode_CheckedChanged(object sender, EventArgs e)
        {
            chkContinuousDrawing.Enabled = !chkInteractiveMode.Checked;
        }


        // --------------------------- Open\Save file Operations ------------------------
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (Shapes.Count is not 0)
            {
                var result = MessageBox.Show("Do you want to save this drawing first?.",
                    "Save Existing Drawing?", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.Yes:
                        Save();
                        OpenFile();
                        break;
                    case DialogResult.No:
                        OpenFile();
                        break;
                    case DialogResult.Cancel:
                    default:
                        break;
                }
            }
            else
                OpenFile();
        }
        private void OpenFile()
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Title = "Open Image File";
                open.Filter = "Image Files (,*.png;*.bmp;*.jpg;*.jpeg;*.gif)|*.PNG;*.BMP;*.JPG;*.JPEG;*.GIF"; open.FilterIndex = 1;
                if (open.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Canvas.Location = default;
                        var bitmap = GetImageFromFile(open.FileName);
                        Canvas.Size = bitmap.Size;
                        Canvas.Image = bitmap;
                        pnlContainer.SetAutoScrollMargin(0, 0);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("It seems you tried to open a corrupted or unsupported image file!.", "Bad File");
                    }
                }
            }
        }

        private Bitmap GetImageFromFile(string path)
        {
            byte[] buff = File.ReadAllBytes(path);
            using MemoryStream ms = new MemoryStream(buff);
            Bitmap bitmap = new Bitmap(ms);
            return bitmap;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Shapes.Count is 0 && Canvas.Image is null)
            {
                MessageBox.Show("Drawing Canvas is empty!.", "Nothing to save");
                return;
            }
            Save();
        }
        private void Save()
        {
            using (var fd = new SaveFileDialog())
            {
                fd.Filter = "PNG files (*.png)|*.png|Bitmap files (*.bmp)|*.bmp|JPG files (*.jpg)|*.jpg|GIF files (*.gif)|*.gif|TIF files (*.tif)|*.tif";
                fd.FilterIndex = 1;
                fd.AddExtension = true;
                fd.OverwritePrompt = true;
                fd.Title = "Save Image";
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    var bitmap = new Bitmap(Canvas.Width, Canvas.Height);
                    Canvas.DrawToBitmap(bitmap, new Rectangle(0, 0, Canvas.Width, Canvas.Height));
                    try
                    {


                        var Extension = Path.GetExtension(fd.FileName).ToLower();
                        switch (Extension)
                        {
                            case ".png":
                                SaveToFile(fd.FileName, bitmap, ImageFormat.Png);
                                break;
                            case ".bmp":
                                SaveToFile(fd.FileName, bitmap, ImageFormat.Bmp);
                                break;
                            case ".jpg":
                                SaveToFile(fd.FileName, bitmap, ImageFormat.Jpeg);
                                break;
                            case ".gif":
                                SaveToFile(fd.FileName, bitmap, ImageFormat.Gif);
                                break;
                            case ".tif":
                                SaveToFile(fd.FileName, bitmap, ImageFormat.Tiff);
                                break;
                            default:
                                break;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("It seems something went wrong and we couldn't save the image!.", "Error!");
                    }
                    finally
                    {
                        bitmap.Dispose();
                    }
                }
            }
        }
        private void SaveToFile(string path, Bitmap bitmap, ImageFormat imageFormat)
        {
            using MemoryStream memory = new MemoryStream();
            using FileStream fs = new FileStream(path, FileMode.Create, FileAccess.ReadWrite);
            bitmap.Save(memory, imageFormat);
            byte[] bytes = memory.ToArray();
            fs.Write(bytes, 0, bytes.Length);
        }
        private void Canvas_MouseLeave(object sender, EventArgs e)
        {
            lblMousePosition.Text = "";
        }

        private void Canvas_Resize(object sender, EventArgs e)
        {
            ShowCanvasSize();            
        }
        private void ShowCanvasSize()
        {
            lblResizeCanvas.Text = $"{Canvas.Width}, {Canvas.Height}";
        }

        //-------------------------------- On Delete key pressed, Delete Figure ------------

        private void Dashboard_KeyDown(object sender, KeyEventArgs e)
        {
            DeleteKeyPressed = e.KeyCode == Keys.Delete ? true : false;
            if (DeleteKeyPressed)
            {
                IShape? FigureMarkToDelete = null;
                foreach (var shape in Shapes)
                {
                    if (shape.Path is null) continue;
                    if (shape.Path.IsOutlineVisible(Canvas.PointToClient(MousePosition), shape.Pen))
                    {
                        FigureMarkToDelete = shape;
                        break;
                    }
                }
                if (FigureMarkToDelete != null)
                {
                    UndoedShapes.Push(FigureMarkToDelete);
                    btnRedo.Enabled = true;
                    Shapes = new Stack<IShape>(Shapes.Where(i => i != FigureMarkToDelete).Reverse());
                    Canvas.Invalidate();
                }
            }
        }

        private void Dashboard_KeyUp(object sender, KeyEventArgs e)
        {
            DeleteKeyPressed = false;
        }

        // ----------------------------- On Closing the app ------------------------------

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.WindowState = WindowState == FormWindowState.Minimized ? (ushort)FormWindowState.Normal : (ushort)WindowState;
            Settings.Default.StrokeColor = btnStroke.BackColor;
            Settings.Default.FillColor = btnFill.BackColor;
            Settings.Default.CanUseFill = chkCanUseFill.Checked;
            Settings.Default.CanvasBackgroundColor = btnCanvasBackgroundColor.BackColor;
            Settings.Default.Save();
        }
    }
}