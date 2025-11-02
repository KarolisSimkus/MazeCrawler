using C_MazeCrawler;
using MazeCrawler;
using System;
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
            map.setMap();
            while (true)
            {
                map.printAllMap();
                Console.ReadLine();
            }
        }
    }
}
