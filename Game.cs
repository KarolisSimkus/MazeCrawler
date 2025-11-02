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
            // TODO make music seperate class
            SoundPlayer soundPlayer = new();
            soundPlayer.SoundLocation = "music.wav";
            soundPlayer.Play();
            map.setMap();
            while (true)
            {
                {
                    Console.Clear();
                    map.draw();

                    char c = (char)Console.Read();
                    ICommand? command = inputHandler.HandleInput(c);
                    if (command != null)
                    {
                        command.Execute(map);
                    }
                }
            }
        }
    }
}
