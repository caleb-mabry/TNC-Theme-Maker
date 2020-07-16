using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNC_Theme_Maker
{
    class FontParser
    {
        public FontParser(string pathToFile)
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
                        int x1 = Int16.Parse(values[0].Trim());
                        int y1 = Int16.Parse(values[1].Trim());
                        int x2 = Int16.Parse(values[2].Trim());
                        int y2 = Int16.Parse(values[3].Trim());
                        Size size = new Size(x1, y1, x2, y2);
                        var newTheme = new Theme(settingName, size);

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

