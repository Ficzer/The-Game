using SFML.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game.Logic
{
    class Control
    {
        public EventHandler getPlayerControl(object sender, KeyEventArgs arg)
        {
            EventHandler eventHandler = new EventHandler(sender, arg);

            return eventHandler;
        }
    }
}
