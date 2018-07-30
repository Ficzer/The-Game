using RPG_Game.Logic;
using SFML.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game.Graphic
{
    static class RenderMonster
    {
        public static CircleShape GetShape(Monster monster)
        {
            var shape = new CircleShape(monster.Size);
            shape.Position = new SFML.System.Vector2f(monster.Position.X, monster.Position.Y);
            shape.Origin = new SFML.System.Vector2f(monster.Size / 2, monster.Size / 2);

            shape.FillColor = Color.White;

            return shape;

        }
    }
}
