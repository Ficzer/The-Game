using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG_Game.Logic;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace RPG_Game.Graphic
{
    static class RenderPlayer
    {
        const int PLAYERSIZE = 20;

        public static CircleShape GetShape(Player player)
        {
            var shape = new CircleShape(PLAYERSIZE);
            shape.Position = new SFML.System.Vector2f(player.Position.X, player.Position.Y);
            shape.Origin = new SFML.System.Vector2f(PLAYERSIZE / 2, PLAYERSIZE / 2);

            if(player is Warrior)
                shape.FillColor = Color.Red;
            else
                shape.FillColor = Color.Blue;

            return shape;
        }

    }
}
