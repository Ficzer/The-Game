using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game.Logic
{
    class Monster : Creature
    {
        protected float size;

        public float Size { get => size; set => size = value; }

        public Monster(string name, Vector2f position) : base(name, position)
        {
        }

        
    }
}
