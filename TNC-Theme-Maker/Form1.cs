using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TNC_Theme_Maker
{
    public partial class Form1 : Form
    {
        private ThemeParser themeParser;
        private Form2 customForm;
        private List<Button> toggleButtons = new List<Button>();
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
                customForm.Controls[option.Name].Visible = false;
                customForm.Controls[option.Name].Hide();
            }
            else
            {
                customForm.Controls[option.Name].Visible = true;
                customForm.Controls[option.Name].Show();
            }
        }

        private void themeFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "ini files (*.ini) |*.ini";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string userSelectFilepath = openFileDialog.FileName; 
                try
                {
                    List<String> possibleFilenames = new List<String>();
                    themeParser = new ThemeParser(userSelectFilepath);
                    //themeParser.themes = themeParser.themes.OrderBy(x => x.name).ToList();
                    customForm = new Form2();
                    int evBgIn = 0;
                    foreach (Theme theme in themeParser.themes)
                    {
                        Button themeButton = new Button();
                        themeButton.Text = theme.name;
                        themeButton.Name = theme.name;
                        themeButton.Visible = true;
                        themeButton.AutoSize = true;
                        themeButton.Show();
                        themeButton.Click += new EventHandler(this.showHide_Click);
                        themeButtonContainer.Controls.Add(themeButton);

                        PictureBox themeImage = new PictureBox();
                        bool isChild = false;
                        string noUnderscoreName = theme.name.Replace("_", string.Empty);
                        string reverseName = string.Join(string.Empty, theme.name.Split('_').Reverse());

                        DirectoryScanner scannedDirectories = new DirectoryScanner(userSelectFilepath);
                        foreach (string pathName in scannedDirectories.ImageFilepaths)
                        {

                            if (pathName.Contains(scannedDirectories.LastFolderName + "\\" + theme.name) || pathName.Contains(scannedDirectories.LastFolderName + "\\" + noUnderscoreName) || pathName.Contains(scannedDirectories.LastFolderName + "\\" + reverseName))
                            {

                                themeImage.Name = theme.name;
                                themeImage.Left = theme.x1;
                                themeImage.Top = theme.y1;
                                themeImage.Width = theme.x2;
                                themeImage.Height = theme.y2;
                                themeImage.Visible = true;
                                themeImage.ImageLocation = pathName;
                                themeImage.SizeMode = PictureBoxSizeMode.StretchImage;
                                customForm.Controls.Add(themeImage);
                                customForm.Controls[themeImage.Name].BringToFront();
                                treeView1.Nodes.Add(themeImage.Name);
                                themeImage.Show();
                                break;
                            }
                        }
                        foreach (TreeNode node in treeView1.Nodes)
                        {
                            if (node.Text == "evidence_background")
                            {
                                evBgIn = node.Index;
                            }
                        }
                        if (theme.name.Contains("evidence") && !theme.name.Contains("background"))
                        {
                            isChild = true;
                            //customForm.Controls[themeImage.Name];
                            treeView1.Nodes[evBgIn].Nodes.Add(theme.name);
                        }
                        if (themeImage.ImageLocation == null)
                        {
                            RichTextBox rtb = new RichTextBox();
                            rtb.Name = theme.name;
                            rtb.Text = theme.name;
                            rtb.Left = theme.x1;
                            rtb.Top = theme.y1;
                            rtb.Width = theme.x2;
                            rtb.Height = theme.y2;
                            rtb.Visible = true;
                            treeView1.Nodes.Add(rtb.Name);
                            customForm.Controls.Add(rtb);
                            customForm.Controls[rtb.Name].BringToFront();
                            rtb.Show();
                        }


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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
