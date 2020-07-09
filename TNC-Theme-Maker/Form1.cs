using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TNC_Theme_Maker
{
    public partial class Form1 : Form
    {
        private ThemeParser themeInformation;
        private Form2 customForm;
        private string selectedValue;
        public Form1()
        {
            InitializeComponent();
        }
        private void showHide_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            var option = customForm.Controls[clickedButton.Text];
            if (option.Visible == true)
            {
                option.Visible = false;
                customForm.Controls[selectedValue].Hide();
            }
            else
            {
                option.Visible = true;
                customForm.Controls[selectedValue].Show();
            }
        }

        private void themeFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "ini files (*.ini) |*.ini";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    themeInformation = new ThemeParser(openFileDialog.FileName);
                    customForm = new Form2();
                    int position = 0;
                    int left = 0;
                    themeInformation.themeSettings = themeInformation.themeSettings.OrderBy(x => x.name).ToList();
                    foreach (ThemeSetting theme in themeInformation.themeSettings)
                    {
                        Button showHide = new Button();
                        showHide.Text = theme.name;
                        showHide.Top = position;
                        showHide.Left = left;
                        showHide.Visible = true;
                        showHide.Show();
                        selectedValue = theme.name;
                        showHide.Click += new EventHandler(this.showHide_Click);
                        position = 5 + showHide.Height + position;
                        if (position >= this.Height)
                        {
                            position = 0;
                            left = left + showHide.Width + 5;
                        }
                        flowLayoutPanel1.Controls.Add(showHide);
                        Console.WriteLine(theme.ToString());
                            RichTextBox newThemeSetting = new RichTextBox();
                            newThemeSetting.Name = theme.name;
                            newThemeSetting.Text = theme.name;
                            newThemeSetting.Left = theme.x1;
                            newThemeSetting.Top = theme.y1;
                            newThemeSetting.Width = theme.x2;
                            newThemeSetting.Height = theme.y2;
                            newThemeSetting.Visible = true;
                            customForm.Controls.Add(newThemeSetting);
                            customForm.Controls[newThemeSetting.Name].BringToFront();
                            newThemeSetting.Show();
                    }
                   

                    customForm.Show();

                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
