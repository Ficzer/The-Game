using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game.Logic
{
    abstract class Monster : Creature
    {
        protected float size;

        public float Size { get => size; set => size = value; }

        public Monster(string name, Vector2f position, float size) : base(name, position)
        {
            this.size = size;
        }

        
    }
}
