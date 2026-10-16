using MazeCrawler;
using System;
using System.Media;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeCrawler
{
    class Game
    {
        public static void RunGame()
        {
            Map map = new Map(10, 10);
            InputHandler inputHandler = new InputHandler();
            SoundManager soundManager = new SoundManager(
                Path.Combine(AppContext.BaseDirectory, "Media", "music.wav"));
            
            map.SetMap();
            soundManager.Play();

            while (map.IsAlive && !map.IsWin)
            {
                {
                    Console.Clear();
                    map.Draw();
                    // TODO Move this to map draw call
                    Console.WriteLine("Has Won: " + map.IsWin);

                    char c = (char)Console.Read();
                    ICommand? command = inputHandler.HandleInput(c);
                    if (command != null)
                    {
                        command.Execute(map);
                    }
                }
            }
            if (!map.IsAlive)
            {
                Console.Clear();
                Console.WriteLine("GAME OVER!");
            }
            else if (map.IsWin)
            {
                Console.Clear();
                Console.WriteLine("You've Won!");
            }
        }
    }
}
