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
        const int mapRows = 10;
        const int mapCols = 10;

        public static void runGame()
        {
            Cell[,] cells = new Cell[mapRows, mapCols];
            
            for (int i = 0; i < mapRows; i++)
            {
                for (int j = 0; j < mapCols; j++) 
                {
                    if(i == 0 || i == mapRows - 1 || j == 0 || j == mapCols - 1)
                    {
                        cells[i, j] = CellFactory.CreateCell(CellType.Wall);
                    }
                    else
                    {
                        cells[i, j] = CellFactory.CreateCell(CellType.Empty);
                    }
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
            while (true)
            {

            }
        }
    }
}
