using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNC_Theme_Maker
{
    class ThemeSetting
    {
        public string name { get; set; }
        public int l1 { get; set; }
        public int l2 { get; set; }
        public int s1 { get; set; }
        public int s2 { get; set; }

        public ThemeSetting(string settingName, int location1, int location2, int size1, int size2)
        {
            this.name = settingName;
            this.l1 = location1;
            this.l2 = location2;
            this.s1 = size1;
            this.s2 = size2;
        }
        public override string ToString()
        {
            return $"Setting Name: {this.name}\nLocation: {l1}, {l2}\nSize: {s1}, {s2}";
        }
    }
}
