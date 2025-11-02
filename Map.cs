using MazeCrawler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_MazeCrawler
{
    class Map
    {
        private int mapRows { get; init; }
        private int mapCols { get; init; }

        Cell[,] cells;

        public Map(int mapRows, int mapCols)
        {
            this.mapRows = mapRows;
            this.mapCols = mapCols;
            this.cells = new Cell[mapRows, mapCols];
        }

        public void printAllMap()
        {
            for (int i = 0; i < mapRows; i++)
            {
                for (int j = 0; j < mapCols; j++)
                {
                    Console.Write("[" + cells[i, j].drawCell() + "]");

                }
                Console.WriteLine();
            }
        }

        public void printFOWMap(int minX, int minY, int maxX, int maxY)
        {
            // Or just give position of player cell
            for (int i = minX; i < maxX; i++)
            {
                for (int j = minY; j < maxY; j++)
                {
                    Console.Write("[" + cells[i, j].drawCell() + "]");

                }
                Console.WriteLine();
            }
        }

        public void setMap()
        {
            for (int i = 0; i < mapRows; i++)
            {
                for (int j = 0; j < mapCols; j++)
                {
                    if (i == 0 || i == mapRows - 1 || j == 0 || j == mapCols - 1)
                    {
                        cells[i, j] = CellFactory.CreateCell(CellType.Wall);
                    }
                    else if(i == 5 && j == 5)
                    {
                        cells[i, j] = CellFactory.CreateCell(CellType.Danger);
                    }
                    else
                    {
                        cells[i, j] = CellFactory.CreateCell(CellType.Empty);
                    }
                }
            }
            //Player, TODO seperate this also no magic numbers pls
            cells[3, 3] = CellFactory.CreateCell(CellType.Player);

        }
    }
}
