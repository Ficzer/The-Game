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

            window.Closed += (sender, arg) => window.Close();

            CreatureRepo repo = new CreatureRepo();
            repo.Player = new Warrior("Dupa", new Vector2f(200,200));

            while(window.IsOpen)
            {
                window.DispatchEvents();

                window.Draw(RenderPlayer.GetShape(repo.Player));
                
                window.Clear();
                window.Display();
            }
            
        }
    }
}
