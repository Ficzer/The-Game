using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG_Game.Graphic;
using RPG_Game.Logic;
using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace RPG_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            RenderWindow window = new RenderWindow(new VideoMode(1000, 800), "Test", Styles.Default);

            CreatureRepo repo = new CreatureRepo();
            repo.Player = new Warrior("Dupa", new Vector2f(200, 200));
            repo.Monsters.Add(new Skeleton("Skeleton1", new Vector2f(400, 400), 20));
            repo.Monsters.Add(new Skeleton("Skeleton2", new Vector2f(600, 400), 20));

            window.Closed += (sender, arg) => window.Close();
            window.KeyPressed += (sender, arg) =>
                {
                    if (Keyboard.IsKeyPressed(Keyboard.Key.D))
                    {
                      
                        repo.Player.Move(Direction.Right);
                    }
                    if (Keyboard.IsKeyPressed(Keyboard.Key.A))
                        repo.Player.Move(Direction.Left);
                    if (Keyboard.IsKeyPressed(Keyboard.Key.S))
                        repo.Player.Move(Direction.Down);
                    if (Keyboard.IsKeyPressed(Keyboard.Key.W))
                        repo.Player.Move(Direction.Up);
                };

           


            while (window.IsOpen)
            {
                window.DispatchEvents();
                window.Clear();

                window.Draw(RenderPlayer.GetShape(repo.Player));

                foreach(Monster mon in repo.Monsters)
                {
                    window.Draw(RenderMonster.GetShape(mon));
                }
                
                window.Display();
            }
            
        }
    }
}
