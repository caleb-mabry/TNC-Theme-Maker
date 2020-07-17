using System.Collections.Generic;

namespace TNCThemeMaker
{
    class Theme
    {
        public string Name { get; set; }
        public Size Size { get; set; }
        public List<Theme> Children = new List<Theme>();


        public Theme(string settingName, Size size)
        {
            this.Name = settingName;
            Size = size;
        }
        public void SetParent(Theme parent)
        {
            parent.Children.Add(this);
            Size parentSize = parent.Size;
            Size.Top += parentSize.Top;
            Size.Left += parentSize.Left;
        }
        public override string ToString()
        {
            return $"{this.Name} = {Size.Left}, {Size.Top}, {Size.Width}, {Size.Height}";
        }
    }
}
