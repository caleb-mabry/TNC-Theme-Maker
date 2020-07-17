using System.Collections.Generic;
using System.Drawing;

namespace TNCThemeMaker
{
    class CourtroomDesign
    {
        public IList<Theme> CourtRoomDesigns { get; }

        public CourtroomDesign()
        {
            var parent = new Theme("chatbox", new Point(0, 883), new Size(0, 668));
            var child = new Theme("showname", new Point(6, 256), new Size(-1, 15));

            child.SetParent(parent);

            CourtRoomDesigns = new List<Theme>();
        }
    }
}
