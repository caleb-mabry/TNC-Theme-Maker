using System;
using System.Collections.Generic;
using System.IO;

namespace TNCThemeMaker
{
    class DirectoryScanner
    {
        public List<String> ImageFilepaths = new List<String>();
        public string LastFolderName;
        public List<string> EvidenceFileNames = new List<String>();

        public DirectoryScanner(string iniFilepath)
        {

            LastFolderName = Path.GetFileName(Path.GetDirectoryName(iniFilepath));
            foreach (var filepath in Directory.EnumerateFiles(Path.GetDirectoryName(iniFilepath), $"*.png", SearchOption.AllDirectories))
            {
                    ImageFilepaths.Add(filepath);
            }
        }
    }
}
