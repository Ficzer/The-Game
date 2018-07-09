using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game.Logic
{
    class CreatureRepo
    {
        private Player player;
        private ArrayList monsters; 


        public Player Player { get => player; set => player = value; }
        public ArrayList Monsters { get => monsters; set => monsters = value; }
    }
}
