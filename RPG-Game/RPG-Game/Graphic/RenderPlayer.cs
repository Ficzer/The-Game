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
        public static CircleShape GetShape(Player player)
        {
            var shape = new CircleShape(50);
            shape.Position = new SFML.System.Vector2f(player.Position.X, player.Position.Y);


            if(player is Warrior)
                shape.FillColor = Color.Red;
            else
                shape.FillColor = Color.Blue;

            return shape;
        }

    }
}
