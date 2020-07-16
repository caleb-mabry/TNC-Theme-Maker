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
        private Control selectedControl;
        private Dictionary<string, PictureBox> DisplayedImageThemes = new Dictionary<string, PictureBox>();
        private Dictionary<string, RichTextBox> DisplayedRTFThemes = new Dictionary<string, RichTextBox>();
        public Form customForm = new Form2();
        
        private List<Button> toggleButtons = new List<Button>();
        public Form1()
        {
            InitializeComponent();
            customForm.FormClosed += new FormClosedEventHandler(cleanupForm2Close);

        }
        private void cleanupForm2Close(object sender, EventArgs e)
        {

        }
        private void displayInformation(object sender, EventArgs e)
        {
            PictureBox clickedImage = (PictureBox)sender;
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
                    foreach(var theme in themeParser.themeImages)
                    {
                        theme.Click += new EventHandler(this.displayInformation);
                        customForm.Controls.Add(theme);
                        Console.WriteLine(theme.Name);
                        theme.Show();
                    }
                    foreach(var rtb in themeParser.textBoxes)
                    {
                        rtb.Click += new EventHandler(this.displayRTFInformation);
                        customForm.Controls.Add(rtb);
                        rtb.Show();
                    }
                    themeParser.ThemeDictionary.OrderBy(x => x.Key);
                    foreach(var key in themeParser.ThemeDictionary.Keys)
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
                                } else
                                {
                                    treeView1.Nodes[theme.name].Nodes.Add(childTheme.name, childTheme.name);

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
            if (isChecked)
            {
                customForm.Controls[e.Node.Text].Show();
            } else
            {
                customForm.Controls[e.Node.Text].Hide();
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
            Console.WriteLine(visibleCheckbox.Checked);
            if (visibleCheckbox.Checked)
            {
                selectedControl.Visible = true;
            } else
            {
                selectedControl.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int indexOfControl = customForm.Controls.GetChildIndex(selectedControl);

            customForm.Controls.SetChildIndex(selectedControl, indexOfControl - 1);
            MoveUp(treeView1.Nodes[selectedControl.Name]);

            Console.WriteLine(indexOfControl);
            currentIndexLabel.Text = customForm.Controls.GetChildIndex(selectedControl).ToString();

        }
        private void backwardsButton_Click(object sender, EventArgs e)
        {
            int indexOfControl = customForm.Controls.GetChildIndex(selectedControl);
            MoveDown(treeView1.Nodes[selectedControl.Name]);
            if (indexOfControl + 1 == customForm.Controls.Count)
            {
                customForm.Controls.SetChildIndex(selectedControl, 0);
            }
            else
            {
                customForm.Controls.SetChildIndex(selectedControl, indexOfControl + 1);
            }
            currentIndexLabel.Text = customForm.Controls.GetChildIndex(selectedControl).ToString();

        }
        // Code pulled from
        // https://stackoverflow.com/questions/2203975/move-node-in-tree-up-or-down
        private void MoveDown(TreeNode node)
        {
            TreeNode parent = node.Parent;
            TreeView view = node.TreeView;
            if (parent != null)
            {
                int index = parent.Nodes.IndexOf(node);
                if (index < parent.Nodes.Count - 1)
                {
                    parent.Nodes.RemoveAt(index);
                    parent.Nodes.Insert(index + 1, node);
                }
            }
            else if (view != null && view.Nodes.Contains(node)) //root node
            {
                int index = view.Nodes.IndexOf(node);
                if (index < view.Nodes.Count - 1)
                {
                    view.Nodes.RemoveAt(index);
                    view.Nodes.Insert(index + 1, node);
                }
            }
        }

        // Code pulled from
        // https://stackoverflow.com/questions/2203975/move-node-in-tree-up-or-down
        private void MoveUp(TreeNode node)
        {
            TreeNode parent = node.Parent;
            TreeView view = node.TreeView;
            if (parent != null)
            {
                int index = parent.Nodes.IndexOf(node);
                if (index > 0)
                {
                    parent.Nodes.RemoveAt(index);
                    parent.Nodes.Insert(index - 1, node);
                }
            }
            else if (node.TreeView.Nodes.Contains(node)) //root node
            {
                int index = view.Nodes.IndexOf(node);
                if (index > 0)
                {
                    view.Nodes.RemoveAt(index);
                    view.Nodes.Insert(index - 1, node);
                }
            }
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
            
            this.topNumberPicker.Value = selectedControl.Top;
            this.leftNumberPicker.Value = selectedControl.Left;
            this.widthNumberPicker.Value = selectedControl.Width;
            this.heightNumberPicker.Value = selectedControl.Height;
            this.selectedImageLabel.Text = selectedControl.Name;
            if (selectedControl is PictureBox)
            {
                PictureBox selectedControl = (PictureBox)customForm.Controls[treeView1.SelectedNode.Name];
                this.selectedImage.ImageLocation = selectedControl.ImageLocation;
            } else
            {
                this.selectedImage.ImageLocation = null;
            }



            Console.WriteLine(treeView1.SelectedNode);
        }
    }
    
}
