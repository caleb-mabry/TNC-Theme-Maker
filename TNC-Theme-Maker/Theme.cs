using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNC_Theme_Maker
{
    class Theme
    {
        public string name { get; set; }
        public int x1 { get; set; }
        public int x2 { get; set; }
        public int y1 { get; set; }
        public int y2 { get; set; }

        public Theme(string settingName, int location1, int location2, int size1, int size2)
        {
            this.name = settingName;
            this.x1 = location1;
            this.y1 = location2;
            this.x2 = size1;
            this.y2 = size2;
        }
        public override string ToString()
        {
            return $"Setting Name: {this.name}\nLocation: {x1}, {y1}\nSize: {x2}, {y2}";
        }
    }
}
