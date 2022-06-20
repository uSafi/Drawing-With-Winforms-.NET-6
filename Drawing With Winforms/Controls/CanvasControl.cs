namespace Drawing_With_Winforms.Controls
{
    internal class CanvasControl: PictureBox
    {
        private const int HTBOTTOMRIGHT = 17;
        const int _ = 5;
        Rectangle BottomRight { get { return new Rectangle(this.ClientSize.Width - _, this.ClientSize.Height - _, _, _); } }
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == 0x84)
            {
                var cursor = this.PointToClient(Cursor.Position);
                if (BottomRight.Contains(cursor)) message.Result = (IntPtr)HTBOTTOMRIGHT;
            }
        }
    }
}
