using System;
using System.Windows.Forms;

namespace TNCThemeMaker
{
    class ThemeButton : Button
    {
        private Button _button1;

        public Button Button { get; private set; }
        public bool IsVisible { get; set; }
        public ThemeButton(Theme theme, int topPos, int leftPos)
        {
            Console.WriteLine(theme.ToString());
            Button = new Button();
            Button.Text = theme.Name;
            Button.Top = topPos;
            Button.Left = leftPos;
            Button.Visible = false;
        }

        private void InitializeComponent()
        {
            this._button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this._button1.Location = new System.Drawing.Point(0, 0);
            this._button1.Name = "_button1";
            this._button1.Size = new System.Drawing.Size(75, 23);
            this._button1.TabIndex = 0;
            this._button1.Text = "button1";
            this._button1.UseVisualStyleBackColor = true;
            this._button1.Click += new System.EventHandler(this.button1_Click);
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
