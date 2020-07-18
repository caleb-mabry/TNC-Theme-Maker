using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TNCThemeMaker.Parser.Ini;

namespace TNCThemeMaker.Parser
{
    class ThemeParser
    {
        private static readonly ThemeIniParser ThemeIniParser = new ThemeIniParser();

        public IDictionary<string, Theme> ThemeDictionary { get; }

        public List<Theme> Themes = new List<Theme>();
        public List<Theme> EvidenceThemes = new List<Theme>();
        public List<ThemeImage> ThemeImages = new List<ThemeImage>();
        public List<RichTextBox> TextBoxes = new List<RichTextBox>();
        private readonly string[] _chatboxChildren = { "showname", "message" };
        private readonly string[] _evidenceChildren = { "evidence_new", "evidence_save", "evidence_load", "evidence_name", "evidence_buttons", "evidence_overlay", "evidence_edit_name", "evidence_delete", "evidence_update", "evidence_image", "evidence_image_name", "evidence_image_button", "evidence_x", "evidence_description", "evidence_left", "evidence_right", "evidence_present", "right_evidence_icon", "left_evidence_icon" };
        private readonly string[] _charChildren = { "char_select_left", "char_select_right", "char_buttons" };

        public ThemeParser(string pathToFile)
        {
            var values = ThemeIniParser.Load(pathToFile);

            var directoryScanner = new DirectoryScanner(pathToFile);
            LoadThemeControls(values, directoryScanner);

            ThemeDictionary = values;
        }

        private void LoadThemeControls(IDictionary<string, Theme> values, DirectoryScanner directoryScanner)
        {
            var usedKeys = new List<string>();
            foreach (var key in values.Keys)
            {

                if (_chatboxChildren.Contains(key))
                {
                    values[key].SetParent(values["chatbox"]);
                    usedKeys.Add(key);

                }
                else if (_evidenceChildren.Contains(key))
                {
                    values[key].SetParent(values["evidence_background"]);
                    usedKeys.Add(key);
                }
                else if (_charChildren.Contains(key))
                {
                    values[key].SetParent(values["char_select"]);
                    usedKeys.Add(key);
                }
                else
                {
                    Themes.Add(values[key]);
                }
            }

            foreach (var key in values.Keys)
            {
                var theme = values[key];
                var themeImage = new ThemeImage(theme.Name, theme.Location, theme.Size);

                var noUnderscoreName = theme.Name.Replace("_", string.Empty);
                var reverseName = string.Join(string.Empty, theme.Name.Split('_').Reverse());

                foreach (var pathName in directoryScanner.ImageFilepaths)
                {
                    if (pathName.Contains(theme.Name) || pathName.Contains(directoryScanner.LastFolderName + "\\" + noUnderscoreName) || pathName.Contains(directoryScanner.LastFolderName + "\\" + reverseName))
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
                values.Remove(key);
            }
        }
    }
}
