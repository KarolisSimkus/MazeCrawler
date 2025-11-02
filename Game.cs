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
        public static void runGame()
        {
            Map map = new Map(10, 10);
            InputHandler inputHandler = new InputHandler();
            SoundManager soundManager = new SoundManager("music.wav");
            
            map.setMap();
            soundManager.Play();

            while (map.isAlive || map.isWin)
            {
                {
                    Console.Clear();
                    map.draw();
                    // TODO Move this to map draw call
                    Console.WriteLine("Has Won: " + map.isWin);

                    char c = (char)Console.Read();
                    ICommand? command = inputHandler.HandleInput(c);
                    if (command != null)
                    {
                        command.Execute(map);
                    }
                }
            }
            if (!map.isAlive)
            {
                Console.Clear();
                Console.WriteLine("GAME OVER!");
            }
            else if (map.isWin)
            {
                Console.Clear();
                Console.WriteLine("You've Won!");
            }
        }
    }
}
