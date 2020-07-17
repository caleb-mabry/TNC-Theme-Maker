using System.Collections.Generic;

namespace TNCThemeMaker
{
    class CourtroomDesign
    {
        public List<Theme> CourtRoomDesigns = new List<Theme>();
        public CourtroomDesign()
        {
            Theme parent = new Theme("chatbox", new Size(0, 883, 0, 668));
            Theme child = new Theme("showname", new Size(6, 256, -1, 15));
            child.SetParent(parent);
            child.Size.ToString();

        }



    }
}
