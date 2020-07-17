using System;
using System.Collections.Generic;
using System.Drawing;
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
        private readonly string[] _chatboxChildren = { "showname", "message" };
        private readonly string[] _evidenceChildren = { "evidence_new", "evidence_save", "evidence_load", "evidence_name", "evidence_buttons", "evidence_overlay", "evidence_edit_name", "evidence_delete", "evidence_update", "evidence_image", "evidence_image_name", "evidence_image_button", "evidence_x", "evidence_description", "evidence_left", "evidence_right", "evidence_present", "right_evidence_icon", "left_evidence_icon" };
        private readonly string[] _charChildren = { "char_select_left", "char_select_right", "char_buttons" };
        public ThemeParser(string pathToFile)
        {
            string line;
            var file = new StreamReader(pathToFile);
            while ((line = file.ReadLine()) != null)
            {
                if (!line.Contains("="))
                    continue;

                var split = line.Split('=');
                var settingName = split[0].Trim();
                try
                {
                    var values = split[1].Split(',');
                    var x = short.Parse(values[0].Trim());
                    var y = short.Parse(values[1].Trim());
                    var width = short.Parse(values[2].Trim());
                    var height = short.Parse(values[3].Trim());

                    var location = new Point(x, y);
                    var size = new Size(width, height);
                    var theme = new Theme(settingName, location, size);

                    ThemeDictionary.Add(settingName, theme);
                }
                catch
                {
                    Console.WriteLine("Not supported.");
                }
            }

            var usedKeys = new List<string>();
            foreach (var key in ThemeDictionary.Keys)
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
                var theme = ThemeDictionary[key];
                var themeImage = new ThemeImage(theme.Name, theme.Location, theme.Size);

                var noUnderscoreName = theme.Name.Replace("_", string.Empty);
                var reverseName = string.Join(string.Empty, theme.Name.Split('_').Reverse());

                var scannedDirectories = new DirectoryScanner(pathToFile);
                foreach (var pathName in scannedDirectories.ImageFilepaths)
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
                    var rtb = new RichTextBox();
                    rtb.Name = theme.Name;
                    rtb.Text = theme.Name;
                    rtb.Left = theme.Location.X;
                    rtb.Top = theme.Location.Y;
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
