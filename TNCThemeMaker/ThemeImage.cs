using System.Windows.Forms;

namespace TNCThemeMaker
{
    class ThemeImage : PictureBox
    {
        public ThemeImage(string themeName, Size size)
        {
            this.Top = size.Top;
            this.Left = size.Left;
            this.Width = size.Width;
            this.Height = size.Height;
            this.Name = themeName;
        }
    }
}
