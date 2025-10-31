using C_MazeCrawler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeCrawler
{
    class Game
    {
        const int mapRows = 10;
        const int mapCols = 10;
        public static void Greet()
        {
            Console.WriteLine("Hello Master");
        }

        public static void runGame()
        {
            Cell[,] cells = new Cell[mapRows, mapCols];
            
            for (int i = 0; i < mapRows; i++)
            {
                for (int j = 0; j < mapCols; j++) 
                {
                    cells[i, j] = CellFactory.CreateCell(i, j);
                }
            }

            for (int i = 0; i < mapRows; i++)
            {
                for (int j = 0; j < mapCols; j++)
                {
                    Console.Write("[" + cells[i, j].drawCell() + "]");
                    
                }
                Console.WriteLine();
            }
        }
    }
}
