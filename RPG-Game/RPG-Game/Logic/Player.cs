using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game.Logic
{
    abstract class Player : Creature
    {
        protected int resource;

        public int Resource { get => resource; set => resource = value; }


        public Player(string name, Vector2f position) : base(name, position)
        {
        }

        
    }
}
