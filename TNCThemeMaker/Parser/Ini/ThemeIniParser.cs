using System.Drawing;

namespace TNCThemeMaker.Parser.Ini
{
    class ThemeIniParser : IniParser<Theme>
    {
        protected override Theme ParseValue(string name, string value)
        {
            var values = value.Split(',');

            var x = int.Parse(values[0].Trim());
            var y = int.Parse(values[1].Trim());
            var width = int.Parse(values[2].Trim());
            var height = int.Parse(values[3].Trim());

            var location = new Point(x, y);
            var size = new Size(width, height);

            return new Theme(name, location, size);
        }
    }
}
