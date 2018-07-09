using RPG_Game.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game
{
    abstract class Creature
    {
        protected const float MOVINGCONST = 0.001f;
        protected String name;
        protected Vector2f position;
        protected Vector2f velocity;
        protected float lookingDirection;
        protected CreatureStatistics statistics;

        public string Name { get => name; set => name = value; }
        public Vector2f Position { get => position; set => position = value; }
        public float LookingDirection { get => lookingDirection; set => lookingDirection = value; }
        public CreatureStatistics Statistics { get => statistics; set => statistics = value; }

        public Creature(String name, Vector2f position)
        {
            Name = name;
            Position = position;
            LookingDirection = 0.0f;
        }

        public virtual void Move(Vector2f velocity)
        {
            Position.X += velocity.X;
            Position.Y += velocity.Y;
        }

        public virtual void Move(Direction direction)
        {
            switch(direction)
            {
                case Direction.Up:
                    Position.Y += MOVINGCONST;
                    break;
                case Direction.Right:
                    Position.X += MOVINGCONST;
                    break;
                case Direction.Down:
                    Position.Y -= MOVINGCONST;
                    break;
                case Direction.Left:
                    Position.X -= MOVINGCONST;
                    break;
            }
        }

        public virtual bool CheckColision(Direction direction)
        {
            return true;
        }

        public virtual bool CheckColision(Vector2f velocity)
        {
            return true;
        }



    }
}
