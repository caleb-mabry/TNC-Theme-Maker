using System;
using System.Collections.Generic;
using System.Drawing;

namespace TNCThemeMaker
{
    class Theme
    {
        public string Name { get; set; }

        // TODO: Keep location relative to parent
        public Point Location { get; private set; }

        public Size Size { get; }

        public Theme Parent { get; private set; }

        public IList<Theme> Children { get; }

        public Theme(string settingName, Point location, Size size)
        {
            if (settingName == null)
                throw new ArgumentNullException(nameof(settingName));

            Name = settingName;
            Location = location;
            Size = size;

            Children = new List<Theme>();
        }

        public Theme(string settingName, Point location, Size size, Theme parent) :
            this(settingName, location, size)
        {
            SetParent(parent);
        }

        public void SetParent(Theme parent)
        {
            if (!parent.Children.Contains(this))
                parent.Children.Add(this);

            Parent = parent;

            Location = new Point(Location.X + parent.Location.X, Location.Y + parent.Location.Y);
        }

        public override string ToString()
        {
            return $"{Name} = {Location.X}, {Location.Y}, {Size.Width}, {Size.Height}";
        }
    }
}
