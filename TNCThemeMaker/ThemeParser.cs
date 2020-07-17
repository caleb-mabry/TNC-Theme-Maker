using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TNCThemeMaker
{
    class ThemeParser
    {
        public List<Theme> Themes = new List<Theme>();
        public Dictionary<string, Theme> ThemeDictionary = new Dictionary<string, Theme>();
        public List<Theme> EvidenceThemes = new List<Theme>();
        public List<ThemeImage> ThemeImages = new List<ThemeImage>();
        public List<RichTextBox> TextBoxes = new List<RichTextBox>();
        private readonly string[] _chatboxChildren = new string[] { "showname", "message" };
        private readonly string[] _evidenceChildren = new string[] { "evidence_new", "evidence_save", "evidence_load", "evidence_name", "evidence_buttons", "evidence_overlay", "evidence_edit_name", "evidence_delete", "evidence_update", "evidence_image", "evidence_image_name", "evidence_image_button", "evidence_x", "evidence_description", "evidence_left", "evidence_right", "evidence_present", "right_evidence_icon", "left_evidence_icon" };
        private readonly string[] _charChildren = new string[] { "char_select_left", "char_select_right", "char_buttons" };
        public ThemeParser(string pathToFile)
        {
            string line;
            StreamReader file = new StreamReader(pathToFile);
            while ((line = file.ReadLine()) != null)
            {

                if (line.Contains("="))
                {
                    string[] split = line.Split('=');
                    string settingName = split[0].Trim();
                    try
                    {
                        string[] values = split[1].Split(',');
                        int left = Int16.Parse(values[0].Trim());
                        int top = Int16.Parse(values[1].Trim());
                        int width = Int16.Parse(values[2].Trim());
                        int height = Int16.Parse(values[3].Trim());
                        Size size = new Size(left, top, width, height);
                        var newTheme = new Theme(settingName, size);
                        ThemeDictionary.Add(settingName, newTheme);
                    }
                    catch
                    {
                        Console.WriteLine("Not supported");
                    }
                }
            }
            List<string> usedKeys = new List<string>();
            foreach (string key in ThemeDictionary.Keys)
            {

                if (_chatboxChildren.Contains(key))
                {
                    ThemeDictionary[key].SetParent(ThemeDictionary["chatbox"]);
                    usedKeys.Add(key);

                }
                else if (_evidenceChildren.Contains(key))
                {
                    ThemeDictionary[key].SetParent(ThemeDictionary["evidence_background"]);
                    usedKeys.Add(key);
                }
                else if (_charChildren.Contains(key))
                {
                    ThemeDictionary[key].SetParent(ThemeDictionary["char_select"]);
                    usedKeys.Add(key);
                }
                else
                {
                    Themes.Add(ThemeDictionary[key]);
                }
            }
            foreach (var key in ThemeDictionary.Keys)
            {
                Theme theme = ThemeDictionary[key];
                ThemeImage themeImage = new ThemeImage(theme.Name, theme.Size);

                string noUnderscoreName = theme.Name.Replace("_", string.Empty);
                string reverseName = string.Join(string.Empty, theme.Name.Split('_').Reverse());

                DirectoryScanner scannedDirectories = new DirectoryScanner(pathToFile);
                foreach (string pathName in scannedDirectories.ImageFilepaths)
                {
                    if (pathName.Contains(theme.Name) || pathName.Contains(scannedDirectories.LastFolderName + "\\" + noUnderscoreName) || pathName.Contains(scannedDirectories.LastFolderName + "\\" + reverseName))
                    {
                        Console.WriteLine("Inside");
                        themeImage.Visible = true;
                        themeImage.ImageLocation = pathName;
                        themeImage.SizeMode = PictureBoxSizeMode.StretchImage;
                        ThemeImages.Add(themeImage);
                        break;
                    }
                }
                if (themeImage.ImageLocation == null)
                {
                    RichTextBox rtb = new RichTextBox();
                    rtb.Name = theme.Name;
                    rtb.Text = theme.Name;
                    rtb.Left = theme.Size.Left;
                    rtb.Top = theme.Size.Top;
                    rtb.Width = theme.Size.Width;
                    rtb.Height = theme.Size.Height;
                    rtb.Visible = true;
                    TextBoxes.Add(rtb);
                }
            }
            foreach (var key in usedKeys)
            {
                ThemeDictionary.Remove(key);
            }
        }
    }
}
