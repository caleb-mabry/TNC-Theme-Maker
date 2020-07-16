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

        public DirectoryScanner(string iniFilepath)
        {

            LastFolderName = Path.GetFileName(Path.GetDirectoryName(iniFilepath));
            foreach (string filepath in Directory.EnumerateFiles(Path.GetDirectoryName(iniFilepath), $"*.png", SearchOption.AllDirectories))
            {
                    ImageFilepaths.Add(filepath);
            }
        }
    }
}
