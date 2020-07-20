using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Windows.Forms;
using TNCThemeMaker.Parser;
using TNCThemeMaker.Properties;

namespace TNCThemeMaker
{
    public partial class Form1 : Form
    {
        private ThemeParser _themeParser;

        private Control _selectedControl;
        private Dictionary<string, PictureBox> _displayedImageThemes = new Dictionary<string, PictureBox>();
        private Dictionary<string, RichTextBox> _displayedRtfThemes = new Dictionary<string, RichTextBox>();
        public Form CustomForm = new Form2();

        private List<Button> _toggleButtons = new List<Button>();

        public Form1()
        {
            InitializeComponent();
            Icon = Resources.icon;
            CustomForm.FormClosed += CleanupForm2Close;

        }

        private void CleanupForm2Close(object sender, EventArgs e)
        {

        }

        private void DisplayInformation(object sender, EventArgs e)
        {
            Control clickedControl;
            if (sender is PictureBox)
            {
                var tempClickedControl = (PictureBox)sender;
                this.selectedImage.ImageLocation = tempClickedControl.ImageLocation;
                clickedControl = tempClickedControl;
            }
            else
            {
                var tempClickedControl = (RichTextBox)sender;
                clickedControl = tempClickedControl;
            }

            treeView1.SelectedNode = treeView1.Nodes[clickedControl.Name];
            this._selectedControl = new RichTextBox();

            this.selectedImageLabel.Text = clickedControl.Name;
            this._selectedControl = clickedControl;
            currentIndexLabel.Text = CustomForm.Controls.GetChildIndex(_selectedControl).ToString();
            //visibleCheckbox.Checked = selectedImage.Visible;

            // Enable Number Pickers and Set Values
            this.topNumberPicker.Enabled = true;
            this.leftNumberPicker.Enabled = true;
            this.widthNumberPicker.Enabled = true;
            this.heightNumberPicker.Enabled = true;
            this.topNumberPicker.Value = _selectedControl.Top;
            this.leftNumberPicker.Value = _selectedControl.Left;
            this.widthNumberPicker.Value = _selectedControl.Width;
            this.heightNumberPicker.Value = _selectedControl.Height;
        }

        private void DisplayRtfInformation(object sender, EventArgs e)
        {
            var clickedImage = (RichTextBox)sender;
            treeView1.SelectedNode = treeView1.Nodes[clickedImage.Name];

            this._selectedControl = new PictureBox();
            this.selectedImage.ImageLocation = string.Empty;
            this.selectedImageLabel.Text = clickedImage.Name;
            _selectedControl = clickedImage;
            //visibleCheckbox.Checked = _selectedControl.Visible;


            currentIndexLabel.Text = CustomForm.Controls.GetChildIndex(_selectedControl).ToString();

            // Enable Number Pickers and Set Values

            this.topNumberPicker.Enabled = true;
            this.leftNumberPicker.Enabled = true;
            this.widthNumberPicker.Enabled = true;
            this.heightNumberPicker.Enabled = true;
            this.topNumberPicker.Value = _selectedControl.Top;
            this.leftNumberPicker.Value = _selectedControl.Left;
            this.widthNumberPicker.Value = _selectedControl.Width;
            this.heightNumberPicker.Value = _selectedControl.Height;

        }

        private void TreeChangeCheck(object sender, TreeViewEventArgs e)
        {
            var isChecked = e.Node.Checked;
            treeView1.SelectedNode = e.Node;
            if (isChecked)
            {
                CustomForm.Controls[e.Node.Text].Show();
                //visibleCheckbox.Checked = true;
                foreach (TreeNode node in treeView1.SelectedNode.Nodes)
                {
                    node.Checked = true;
                }
            }
            else
            {
                CustomForm.Controls[e.Node.Text].Hide();
                //visibleCheckbox.Checked = false;
                foreach (TreeNode node in treeView1.SelectedNode.Nodes)
                {
                    node.Checked = false;
                }
            }
        }
        private void topNumberPicker_ValueChanged(object sender, EventArgs e)
        {
            this._selectedControl.Top = (int)this.topNumberPicker.Value;
            this._selectedControl.Top = (int)this.topNumberPicker.Value;

        }

        private void leftNumberPicker_ValueChanged(object sender, EventArgs e)
        {
            this._selectedControl.Left = (int)this.leftNumberPicker.Value;
            this._selectedControl.Left = (int)this.leftNumberPicker.Value;

        }

        private void widthNumberPicker_ValueChanged(object sender, EventArgs e)
        {
            this._selectedControl.Width = (int)this.widthNumberPicker.Value;
            this._selectedControl.Width = (int)this.widthNumberPicker.Value;
        }

        private void heightNumberPicker_ValueChanged(object sender, EventArgs e)
        {
            this._selectedControl.Height = (int)this.heightNumberPicker.Value;
            this._selectedControl.Height = (int)this.heightNumberPicker.Value;

        }

        //private void visibleCheckbox_CheckedChanged(object sender, EventArgs e)
        //{
        //    var possibleParent = treeView1.SelectedNode.Parent;
        //    Console.WriteLine((bool)visibleCheckbox.Checked);
        //    if (visibleCheckbox.Checked)
        //    {
        //        if (possibleParent != null)
        //        {
        //            treeView1.Nodes[possibleParent.Name].Nodes[_selectedControl.Name].Checked = true;

        //        }
        //        else
        //        {
        //            treeView1.Nodes[_selectedControl.Name].Checked = true;

        //        }
        //        _selectedControl.Visible = true;
        //    }
        //    else
        //    {
        //        if (possibleParent != null)
        //        {
        //            treeView1.Nodes[possibleParent.Name].Nodes[_selectedControl.Name].Checked = false;

        //        }
        //        else
        //        {
        //            treeView1.Nodes[_selectedControl.Name].Checked = false;
        //        }
        //        _selectedControl.Visible = false;
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            var indexOfControl = CustomForm.Controls.GetChildIndex(_selectedControl);
            //MoveUp(treeView1.Nodes[selectedControl.Name]);
            CustomForm.Controls.SetChildIndex(_selectedControl, indexOfControl - 1);
            currentIndexLabel.Text = CustomForm.Controls.GetChildIndex(_selectedControl).ToString();

        }
        private void backwardsButton_Click(object sender, EventArgs e)
        {
            var indexOfControl = CustomForm.Controls.GetChildIndex(_selectedControl);
            //MoveDown(treeView1.Nodes[selectedControl.Name]);
            CustomForm.Controls.SetChildIndex(_selectedControl, indexOfControl + 1);

            currentIndexLabel.Text = CustomForm.Controls.GetChildIndex(_selectedControl).ToString();

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            _selectedControl = CustomForm.Controls[(string)treeView1.SelectedNode.Name];
            Console.WriteLine(_selectedControl.Name);
            currentIndexLabel.Text = CustomForm.Controls.GetChildIndex(_selectedControl).ToString();

            this.topNumberPicker.Value = _selectedControl.Top;
            this.leftNumberPicker.Value = _selectedControl.Left;
            this.widthNumberPicker.Value = _selectedControl.Width;
            this.heightNumberPicker.Value = _selectedControl.Height;
            this.selectedImageLabel.Text = _selectedControl.Name;
            if (_selectedControl is PictureBox)
            {
                var selectedControl = (PictureBox)CustomForm.Controls[(string)treeView1.SelectedNode.Name];
                this.selectedImage.ImageLocation = selectedControl.ImageLocation;
            }
            else
            {
                this.selectedImage.ImageLocation = null;
            }
        }

        #region Events

        private void tsmOpen_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void tsmSave_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        #endregion

        #region Open File

        private void OpenFile()
        {
            _displayedImageThemes.Clear();
            _displayedRtfThemes.Clear();

            var ofd = new OpenFileDialog
            {
                Filter = "ini files (*.ini) |*.ini"
            };

            if (ofd.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("An error occurred when selecting a file.", "Load error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            OpenFile(ofd.FileName);
        }

        private void OpenFile(string file)
        {
            try
            {
                _themeParser = new ThemeParser(file);

                // Add the themes in the appropriate order
                foreach (var themeName in _themeParser.ItemOrder)
                {
                    int themeIndex = _themeParser.ThemeImages.FindIndex(x => x.Name == themeName);
                    int rtbIndex = _themeParser.TextBoxes.FindIndex(x => x.Name == themeName);
                    if (themeIndex != -1)
                    {
                        _themeParser.ThemeImages[themeIndex].Click += DisplayInformation;
                        CustomForm.Controls.Add(_themeParser.ThemeImages[themeIndex]);
                    }
                    else if (rtbIndex != -1)
                    {
                        _themeParser.TextBoxes[rtbIndex].Click += DisplayInformation;
                        CustomForm.Controls.Add(_themeParser.TextBoxes[rtbIndex]);
                    }
                    else
                    {
                        throw new KeyNotFoundException($"Unable to find a value {themeName} in {file}");
                    }
                }
                //foreach (var theme in _themeParser.ThemeImages)
                //{
                //    theme.Click += DisplayInformation;
                //    CustomForm.Controls.Add(theme);
                //    Console.WriteLine(theme.Name);
                //    theme.Show();
                //}

                //foreach (var rtb in _themeParser.TextBoxes)
                //{
                //    rtb.Click += DisplayRtfInformation;
                //    CustomForm.Controls.Add(rtb);
                //    rtb.Show();
                //}

                _themeParser.ThemeDictionary.OrderBy(x => x.Key);
                foreach (var key in _themeParser.ThemeDictionary.Keys)
                {
                    var theme = _themeParser.ThemeDictionary[key];
                    treeView1.Nodes.Add(theme.Name, theme.Name);
                    treeView1.Nodes[theme.Name].Checked = true;
                    if (theme.Children.Count > 0)
                    {
                        foreach (var childTheme in theme.Children)
                        {
                            if (treeView1.Nodes.ContainsKey(childTheme.Name))
                            {
                                treeView1.Nodes.RemoveByKey(childTheme.Name);
                            }
                            else
                            {
                                treeView1.Nodes[theme.Name].Nodes.Add(childTheme.Name, childTheme.Name);
                                treeView1.Nodes[theme.Name].Nodes[childTheme.Name].Checked = true;

                            }
                        }
                    }
                }
                totalIndexLabel.Text = (CustomForm.Controls.Count - 1).ToString();
                treeView1.AfterCheck += TreeChangeCheck;

                CustomForm.Show();

            }
            catch (SecurityException ex)
            {
                MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                $"Details:\n\n{ex.StackTrace}");
                return;
            }

            tsmSave.Enabled = true;
        }

        #endregion

        #region Save File

        private void SaveFile()
        {
            var sfd = new SaveFileDialog
            {
                FileName = "NewTheme.ini",
                Filter = "INI File|*.ini",
                Title = "Save INI File"
            };

            if (sfd.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("An error occurred when selecting the file.", "Save error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            SaveFile(sfd.FileName);
        }

        private void SaveFile(string savePath)
        {
            var saveStream = File.OpenWrite(savePath);

            var writer = new StreamWriter(saveStream);
            foreach (Control theme in CustomForm.Controls)
            {
                writer.WriteLine($"{theme.Name} = {theme.Left}, {theme.Top}, {theme.Width}, {theme.Height}");
            }

            // Code to write the stream goes here.
            writer.Close();
        }

        #endregion
    }
}
