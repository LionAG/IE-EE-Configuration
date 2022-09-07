using System.Drawing.Drawing2D;

namespace ConfigUtility.UI.Controls
{
    class RoundPictureBox : PictureBox
    {
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            using var graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(new Rectangle(0, 0, this.Width - 1, this.Height - 1));

            Region = new Region(graphicsPath);
        }
    }
}
