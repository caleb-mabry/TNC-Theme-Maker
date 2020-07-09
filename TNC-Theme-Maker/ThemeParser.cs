using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNC_Theme_Maker
{
    class ThemeParser
    {
        public List<ThemeSetting> themeSettings = new List<ThemeSetting>(); 
        public ThemeParser (string pathToFile)
        {
            string line;
            StreamReader file = new StreamReader(pathToFile);
            while((line = file.ReadLine())!= null)
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
                        themeSettings.Add(new ThemeSetting(settingName, x1, y1, x2, y2));
                    } catch
                    {
                        Console.WriteLine("Not supported");
                    }
                }
            }
        }
    }
}
