using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TNC_Theme_Maker
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
