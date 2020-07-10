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
        private Button button1;

        public Button button { get; private set; }
        public bool IsVisible { get; set; }
        public ThemeButton(Theme theme, int topPos, int leftPos)
        {
            Console.WriteLine(theme.ToString());
            button = new Button();
            button.Text = theme.name;
            button.Top = topPos;
            button.Left = leftPos;
            button.Visible = false;
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
