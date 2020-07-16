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
        public Size Size { get; set; }
        public List<Theme> children = new List<Theme>();


        public Theme(string settingName, Size size)
        {
            this.name = settingName;
            Size = size;
        }
        public void SetParent(Theme parent)
        {
            parent.children.Add(this);
            Size parentSize = parent.Size;
            Size.Top += parentSize.Top;
            Size.Left += parentSize.Left;
        }
        public override string ToString()
        {
            return $"{this.name} = {Size.Left}, {Size.Top}, {Size.Width}, {Size.Height}";
        }
    }
}
