using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game.Logic
{
    class CreatureStatistics
    {
        private int health;
        private int physicalAttack;
        private int magicAttack;
        private int armor;
        private int magicResistance;

        public int Health { get => health; set => health = value; }
        public int PhysicalAttack { get => physicalAttack; set => physicalAttack = value; }
        public int MagicAttack { get => magicAttack; set => magicAttack = value; }
        public int Armor { get => armor; set => armor = value; }
        public int MagicResistance { get => magicResistance; set => magicResistance = value; }
    }
}
