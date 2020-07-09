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
        public Form1()
        {
            InitializeComponent();
        }

        private void themeFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    themeInformation = new ThemeParser(openFileDialog.FileName);
                    customForm = new Form2();

                    foreach (ThemeSetting theme in themeInformation.themeSettings)
                    {
                        Console.WriteLine(theme.ToString());
                        RichTextBox newThemeSetting = new RichTextBox();
                        newThemeSetting.Text = theme.name;
                        newThemeSetting.Location = new Point(theme.l1, theme.l2);
                        newThemeSetting.Width = theme.s1;
                        newThemeSetting.Height = theme.s2;
                        newThemeSetting.
                        customForm.Controls.Add(newThemeSetting);
                        newThemeSetting.Show();
                    }
                    customForm.ShowDialog();

                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }


    }
}
