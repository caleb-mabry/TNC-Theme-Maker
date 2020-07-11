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
        private int temp;
        private PictureBox selectedThemeImage = new PictureBox();
        private RichTextBox selectedThemeRTB = new RichTextBox();
        private Dictionary<string, PictureBox> DisplayedImageThemes = new Dictionary<string, PictureBox>();
        private Dictionary<string, RichTextBox> DisplayedRTFThemes = new Dictionary<string, RichTextBox>();

        private Form2 customForm;
        private List<Button> toggleButtons = new List<Button>();
        public Form1()
        {
            InitializeComponent();
        }
        private void displayImageInformation(object sender, EventArgs e)
        {
            PictureBox clickedImage = (PictureBox)sender;
            this.selectedThemeRTB = new RichTextBox();
            this.selectedImage.ImageLocation = clickedImage.ImageLocation;
            this.selectedImageLabel.Text = clickedImage.Name;
            selectedThemeImage = DisplayedImageThemes[clickedImage.Name];
            Console.WriteLine(selectedThemeImage.Visible);
            visibleCheckbox.Checked = selectedImage.Visible;

            // Enable Number Pickers and Set Values
            this.topNumberPicker.Enabled = true;
            this.leftNumberPicker.Enabled = true;
            this.widthNumberPicker.Enabled = true;
            this.heightNumberPicker.Enabled = true;
            this.topNumberPicker.Value = selectedThemeImage.Top;
            this.leftNumberPicker.Value = selectedThemeImage.Left;
            this.widthNumberPicker.Value = selectedThemeImage.Width;
            this.heightNumberPicker.Value = selectedThemeImage.Height;
        }

        private void displayRTFInformation(object sender, EventArgs e)
        {
            RichTextBox clickedImage = (RichTextBox)sender;
            this.selectedThemeImage = new PictureBox();
            this.selectedImage.ImageLocation = string.Empty;
            this.selectedImageLabel.Text = clickedImage.Name;
            selectedThemeRTB = DisplayedRTFThemes[clickedImage.Name];
            visibleCheckbox.Checked = selectedThemeRTB.Visible;
            // Enable Number Pickers and Set Values
            this.topNumberPicker.Enabled = true;
            this.leftNumberPicker.Enabled = true;
            this.widthNumberPicker.Enabled = true;
            this.heightNumberPicker.Enabled = true;
            this.topNumberPicker.Value = selectedThemeRTB.Top;
            this.leftNumberPicker.Value = selectedThemeRTB.Left;
            this.widthNumberPicker.Value = selectedThemeRTB.Width;
            this.heightNumberPicker.Value = selectedThemeRTB.Height;

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
                        PictureBox themeImage = new PictureBox();
                        string noUnderscoreName = theme.name.Replace("_", string.Empty);
                        string reverseName = string.Join(string.Empty, theme.name.Split('_').Reverse());

                        DirectoryScanner scannedDirectories = new DirectoryScanner(userSelectFilepath);
                        foreach (string pathName in scannedDirectories.ImageFilepaths)
                        {
                            Console.WriteLine(pathName);


                            if (pathName.Contains(theme.name) || pathName.Contains(scannedDirectories.LastFolderName + "\\" + noUnderscoreName) || pathName.Contains(scannedDirectories.LastFolderName + "\\" + reverseName))
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
                                DisplayedImageThemes.Add(themeImage.Name, themeImage);
                                themeImage.Click += new EventHandler(this.displayImageInformation);
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
                            DisplayedRTFThemes.Add(rtb.Name, rtb);
                            rtb.Click += new EventHandler(this.displayRTFInformation);
                            treeView1.Nodes.Add(rtb.Name);
                            customForm.Controls.Add(rtb);
                            customForm.Controls[rtb.Name].BringToFront();
                            rtb.Show();
                        }


                    }
                    setChildren();
                    customForm.Show();

                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }
        private void setChildren()
        {
            RichTextBox showName = DisplayedRTFThemes["showname"];
            RichTextBox message = DisplayedRTFThemes["message"];
            RichTextBox parentChat = DisplayedRTFThemes["chatbox"];

            showName.Left = parentChat.Left + showName.Left;
            message.Left = parentChat.Left + message.Left;
            showName.Top = parentChat.Top + showName.Top;
            message.Top = parentChat.Top + message.Top;

        }
        private void topNumberPicker_ValueChanged(object sender, EventArgs e)
        {
            this.selectedThemeImage.Top = (int)this.topNumberPicker.Value;
            this.selectedThemeRTB.Top = (int)this.topNumberPicker.Value;

        }

        private void leftNumberPicker_ValueChanged(object sender, EventArgs e)
        {
                this.selectedThemeImage.Left = (int)this.leftNumberPicker.Value;
                this.selectedThemeRTB.Left = (int)this.leftNumberPicker.Value;

        }

        private void widthNumberPicker_ValueChanged(object sender, EventArgs e)
        {
                this.selectedThemeImage.Width = (int)this.widthNumberPicker.Value;
                this.selectedThemeRTB.Width = (int)this.widthNumberPicker.Value;
        }

        private void heightNumberPicker_ValueChanged(object sender, EventArgs e)
        {
            this.selectedThemeRTB.Height = (int)this.heightNumberPicker.Value;
            this.selectedThemeImage.Height = (int)this.heightNumberPicker.Value;
            
        }

        private void visibleCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine(visibleCheckbox.Checked);
            if (visibleCheckbox.Checked)
            {
                selectedThemeImage.Visible = true;
                selectedThemeRTB.Visible = true;
            } else
            {
                selectedThemeImage.Visible = false;
                selectedThemeRTB.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var controlLength = customForm.Controls.Count;
            List<string> listOfKeys = new List<string>();
            var selectedImageName = selectedImage.Name;
            var selectedRTFName = selectedThemeRTB.Name;
            for (var i = 0; i < controlLength; i++) {
                if (customForm.Controls[i].Name != "")
                {
                    listOfKeys.Add(customForm.Controls[i].Name);
                }
            }
            var temp1=listOfKeys.IndexOf(selectedImageName);
            var temp2 = listOfKeys.IndexOf(selectedRTFName);
            if (temp1 >= 0)
            {
                temp = temp1;
            } else
            {
                temp = temp2;
            }
        }
    }
}
