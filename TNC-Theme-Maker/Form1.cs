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
using TNC_Theme_Maker.Properties;

namespace TNC_Theme_Maker
{
    public partial class Form1 : Form
    {
        private ThemeParser themeParser;
        private Control selectedControl;
        private Dictionary<string, PictureBox> DisplayedImageThemes = new Dictionary<string, PictureBox>();
        private Dictionary<string, RichTextBox> DisplayedRTFThemes = new Dictionary<string, RichTextBox>();
        public Form customForm = new Form2();

        private List<Button> toggleButtons = new List<Button>();
        public Form1()
        {
            InitializeComponent();
            Icon = Resources.icon;
            customForm.FormClosed += new FormClosedEventHandler(cleanupForm2Close);

        }
        private void cleanupForm2Close(object sender, EventArgs e)
        {

        }
        private void displayInformation(object sender, EventArgs e)
        {
            PictureBox clickedImage = (PictureBox)sender;
            treeView1.SelectedNode = treeView1.Nodes[clickedImage.Name];
            this.selectedControl = new RichTextBox();
            this.selectedImage.ImageLocation = clickedImage.ImageLocation;
            this.selectedImageLabel.Text = clickedImage.Name;
            selectedControl = clickedImage;
            currentIndexLabel.Text = customForm.Controls.GetChildIndex(selectedControl).ToString();
            visibleCheckbox.Checked = selectedImage.Visible;

            // Enable Number Pickers and Set Values
            this.topNumberPicker.Enabled = true;
            this.leftNumberPicker.Enabled = true;
            this.widthNumberPicker.Enabled = true;
            this.heightNumberPicker.Enabled = true;
            this.topNumberPicker.Value = selectedControl.Top;
            this.leftNumberPicker.Value = selectedControl.Left;
            this.widthNumberPicker.Value = selectedControl.Width;
            this.heightNumberPicker.Value = selectedControl.Height;
        }

        private void displayRTFInformation(object sender, EventArgs e)
        {
            RichTextBox clickedImage = (RichTextBox)sender;
            treeView1.SelectedNode = treeView1.Nodes[clickedImage.Name];

            this.selectedControl = new PictureBox();
            this.selectedImage.ImageLocation = string.Empty;
            this.selectedImageLabel.Text = clickedImage.Name;
            selectedControl = clickedImage;
            visibleCheckbox.Checked = selectedControl.Visible;


            currentIndexLabel.Text = customForm.Controls.GetChildIndex(selectedControl).ToString();

            // Enable Number Pickers and Set Values

            this.topNumberPicker.Enabled = true;
            this.leftNumberPicker.Enabled = true;
            this.widthNumberPicker.Enabled = true;
            this.heightNumberPicker.Enabled = true;
            this.topNumberPicker.Value = selectedControl.Top;
            this.leftNumberPicker.Value = selectedControl.Left;
            this.widthNumberPicker.Value = selectedControl.Width;
            this.heightNumberPicker.Value = selectedControl.Height;

        }


        private void themeFile_Click(object sender, EventArgs e)
        {
            this.DisplayedImageThemes.Clear();
            this.DisplayedRTFThemes.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "ini files (*.ini) |*.ini";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string userSelectFilepath = openFileDialog.FileName;
                try
                {
                    themeParser = new ThemeParser(userSelectFilepath);
                    foreach (var theme in themeParser.themeImages)
                    {
                        theme.Click += new EventHandler(this.displayInformation);
                        customForm.Controls.Add(theme);
                        Console.WriteLine(theme.Name);
                        theme.Show();
                    }
                    foreach (var rtb in themeParser.textBoxes)
                    {
                        rtb.Click += new EventHandler(this.displayRTFInformation);
                        customForm.Controls.Add(rtb);
                        rtb.Show();
                    }
                    themeParser.ThemeDictionary.OrderBy(x => x.Key);
                    foreach (var key in themeParser.ThemeDictionary.Keys)
                    {
                        Theme theme = themeParser.ThemeDictionary[key];
                        treeView1.Nodes.Add(theme.name, theme.name);
                        treeView1.Nodes[theme.name].Checked = true;
                        if (theme.children.Count > 0)
                        {
                            foreach (var childTheme in theme.children)
                            {
                                if (treeView1.Nodes.ContainsKey(childTheme.name))
                                {
                                    treeView1.Nodes.RemoveByKey(childTheme.name);
                                }
                                else
                                {
                                    treeView1.Nodes[theme.name].Nodes.Add(childTheme.name, childTheme.name);
                                    treeView1.Nodes[theme.name].Nodes[childTheme.name].Checked = true;

                                }
                            }
                        }
                    }
                    totalIndexLabel.Text = (customForm.Controls.Count - 1).ToString();
                    treeView1.AfterCheck += new TreeViewEventHandler(treeChangeCheck);

                    customForm.Show();

                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }
        private void treeChangeCheck(object sender, TreeViewEventArgs e)
        {
            bool isChecked = e.Node.Checked;
            treeView1.SelectedNode = e.Node;
            if (isChecked)
            {
                customForm.Controls[e.Node.Text].Show();
                visibleCheckbox.Checked = true;
                foreach (TreeNode node in treeView1.SelectedNode.Nodes)
                {
                    node.Checked = true;
                }
            }
            else
            {
                customForm.Controls[e.Node.Text].Hide();
                visibleCheckbox.Checked = false;
                foreach (TreeNode node in treeView1.SelectedNode.Nodes)
                {
                    node.Checked = false;
                }
            }
        }
        private void topNumberPicker_ValueChanged(object sender, EventArgs e)
        {
            this.selectedControl.Top = (int)this.topNumberPicker.Value;
            this.selectedControl.Top = (int)this.topNumberPicker.Value;

        }

        private void leftNumberPicker_ValueChanged(object sender, EventArgs e)
        {
            this.selectedControl.Left = (int)this.leftNumberPicker.Value;
            this.selectedControl.Left = (int)this.leftNumberPicker.Value;

        }

        private void widthNumberPicker_ValueChanged(object sender, EventArgs e)
        {
            this.selectedControl.Width = (int)this.widthNumberPicker.Value;
            this.selectedControl.Width = (int)this.widthNumberPicker.Value;
        }

        private void heightNumberPicker_ValueChanged(object sender, EventArgs e)
        {
            this.selectedControl.Height = (int)this.heightNumberPicker.Value;
            this.selectedControl.Height = (int)this.heightNumberPicker.Value;

        }

        private void visibleCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            TreeNode possibleParent = treeView1.SelectedNode.Parent;
            Console.WriteLine(visibleCheckbox.Checked);
            if (visibleCheckbox.Checked)
            {
                if (possibleParent != null)
                {
                    treeView1.Nodes[possibleParent.Name].Nodes[selectedControl.Name].Checked = true;

                }
                else
                {
                    treeView1.Nodes[selectedControl.Name].Checked = true;

                }
                selectedControl.Visible = true;
            }
            else
            {
                if (possibleParent != null)
                {
                    treeView1.Nodes[possibleParent.Name].Nodes[selectedControl.Name].Checked = false;

                }
                else
                {
                    treeView1.Nodes[selectedControl.Name].Checked = false;
                }
                selectedControl.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int indexOfControl = customForm.Controls.GetChildIndex(selectedControl);
            //MoveUp(treeView1.Nodes[selectedControl.Name]);
            customForm.Controls.SetChildIndex(selectedControl, indexOfControl - 1);
            currentIndexLabel.Text = customForm.Controls.GetChildIndex(selectedControl).ToString();

        }
        private void backwardsButton_Click(object sender, EventArgs e)
        {
            int indexOfControl = customForm.Controls.GetChildIndex(selectedControl);
            //MoveDown(treeView1.Nodes[selectedControl.Name]);
            customForm.Controls.SetChildIndex(selectedControl, indexOfControl + 1);

            currentIndexLabel.Text = customForm.Controls.GetChildIndex(selectedControl).ToString();

        }




        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = "New_Theme.ini";
            saveFileDialog1.Filter = "INI File|*.ini";
            saveFileDialog1.Title = "Save INI File";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveFileDialog1.OpenFile());
                foreach (Control theme in customForm.Controls)
                {
                    writer.WriteLine($"{theme.Name} = {theme.Left}, {theme.Top}, {theme.Width}, {theme.Height}");
                }
                // Code to write the stream goes here.
                writer.Close();
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            selectedControl = customForm.Controls[treeView1.SelectedNode.Name];
            Console.WriteLine(selectedControl.Name);
            currentIndexLabel.Text = customForm.Controls.GetChildIndex(selectedControl).ToString();

            this.topNumberPicker.Value = selectedControl.Top;
            this.leftNumberPicker.Value = selectedControl.Left;
            this.widthNumberPicker.Value = selectedControl.Width;
            this.heightNumberPicker.Value = selectedControl.Height;
            this.selectedImageLabel.Text = selectedControl.Name;
            if (selectedControl is PictureBox)
            {
                PictureBox selectedControl = (PictureBox)customForm.Controls[treeView1.SelectedNode.Name];
                this.selectedImage.ImageLocation = selectedControl.ImageLocation;
            }
            else
            {
                this.selectedImage.ImageLocation = null;
            }
        }
    }

}
