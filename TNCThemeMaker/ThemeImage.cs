using System;
using System.Drawing;
using System.Windows.Forms;

namespace TNCThemeMaker
{
    class ThemeImage : PictureBox
    {
        public ThemeImage(string themeName, Point location, Size size)
        {
            if (themeName == null)
                throw new ArgumentNullException(nameof(themeName));

            Name = themeName;

            Top = location.Y;
            Left = location.X;
            Width = size.Width;
            Height = size.Height;
        }
    }
}
