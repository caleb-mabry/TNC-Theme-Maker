using System;
using System.Drawing;
using System.IO;

namespace TNCThemeMaker
{
    class FontParser
    {
        public FontParser(string pathToFile)
        {
            string line;
            var file = new StreamReader(pathToFile);
            while ((line = file.ReadLine()) != null)
            {

                if (line.Contains("="))
                {
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

                        if (settingName.Contains("evidence"))
                        {
                            //EvidenceThemes.Add(newTheme);
                            //ThemeDictionary.Add(settingName, newTheme);

                        }
                        else
                        {
                            //    themes.Add(new Theme(settingName, x1, y1, x2, y2));
                            //    ThemeDictionary.Add(settingName, newTheme);
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Not supported");
                    }
                }
            }
        }
    }
}

