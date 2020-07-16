using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNC_Theme_Maker
{
    class Courtroom_Design
    {
        public List<Theme> CourtRoom_Designs = new List<Theme>();
        public Courtroom_Design()
        {
            Theme parent = new Theme("chatbox", new Size(0, 883, 0, 668));
            Theme child = new Theme("showname", new Size(6, 256, -1, 15));
            child.SetParent(parent);
            child.Size.ToString();

        }



    }
}
