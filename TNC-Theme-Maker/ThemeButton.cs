using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TNC_Theme_Maker
{
    class ThemeButton : Button
    {
        public Button button { get; private set; }
        public bool IsVisible { get; set; }
        public ThemeButton(ThemeSetting theme, int topPos, int leftPos)
        {
            Console.WriteLine(theme.ToString());
            button = new Button();
            button.Text = theme.name;
            button.Top = topPos;
            button.Left = leftPos;
            button.Visible = false;
        }
    }
}
