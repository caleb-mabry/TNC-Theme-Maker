using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNC_Theme_Maker
{
    class DirectoryScanner
    {
        public List<String> ImageFilepaths = new List<String>();
        public string LastFolderName;
        public List<string> EvidenceFileNames = new List<String>();
        public List<string> OtherFileNames;

        public DirectoryScanner(string iniFilepath)
        {

            LastFolderName = Path.GetFileName(Path.GetDirectoryName(iniFilepath));
            foreach (string filepath in Directory.EnumerateFiles(Path.GetDirectoryName(iniFilepath), $"*.png", SearchOption.AllDirectories))

            //foreach (string file in Directory.EnumerateFiles(Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(iniFilepath))), $"{LastFolderName}*.png", SearchOption.AllDirectories))
            {

                    ImageFilepaths.Add(filepath);

            }
        }
        //public void ImageFilter(List<Theme> themes)
        //{
        //    foreach (Theme theme in themes)
        //    {
        //        string noUnderscoreName = theme.name.Replace("_", string.Empty);
        //        string reverseName = string.Join(string.Empty, theme.name.Split('_').Reverse());
        //        if (pathName.Contains(scannedDirectories.LastFolderName + "\\" + theme.name) || pathName.Contains(scannedDirectories.LastFolderName + "\\" + noUnderscoreName) || pathName.Contains(scannedDirectories.LastFolderName + "\\" + reverseName))
        //        {

        //        }
        //    }
        //}
    }
}
