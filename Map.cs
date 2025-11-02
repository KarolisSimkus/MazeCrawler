using MazeCrawler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeCrawler
{
    class Map
    {
        private int mapRows { get; init; }
        private int mapCols { get; init; }
        public bool isAlive = true;
        public bool isWin = false;

        Cell[,] cells;
        CellPlayer player;

        public Map(int mapRows, int mapCols)
        {
            this.mapRows = mapRows;
            this.mapCols = mapCols;
            this.cells = new Cell[mapRows, mapCols];
            this.player = new CellPlayer(3, 3);
        }
        private void printTopLegend()
        {
            Console.WriteLine("[w,a,s,d]");
        }
        private void printBottomLegend()
        {
            Console.WriteLine("Keycount:" + player.keyCount);
            Console.WriteLine("Doors Opened:" + player.doorCount);
        }
        public void draw()
        {
            printTopLegend();
            printFOWMap();
            //printAllMap();
            printBottomLegend();
        }
        private void printAllMap()
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
        public void printFOWMap()
        {
            for (int i = player.X - 1; i < player.X + 2; i++)
            {
                for (int j = player.Y - 1; j < player.Y + 2; j++)
                {
                    Console.Write("[" + cells[i, j].drawCell() + "]");

                }
                Console.WriteLine();
            }
        }

        public void setMap()
        {
            // TODO somehow refactor this, idk if the ifs are good here
            // Its a pain in the ass to make actual maps
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
                        cells[i, j] = CellFactory.CreateCell(CellType.Key);
                    }
                    else if(i == 5 && j == 6)
                    {
                        cells[i, j] = CellFactory.CreateCell(CellType.Danger);
                    }
                    else if(i == 7 && j == 7)
                    {
                        cells[i, j] = CellFactory.CreateCell(CellType.Door);
                    }
                    else
                    {
                        cells[i, j] = CellFactory.CreateCell(CellType.Empty);
                    }
                }
            }
            cells[player.X, player.Y] = CellFactory.CreateCell(CellType.Player);

        }
        public void ReplaceCell(int x, int y, Cell newCell)
        {
            cells[x, y] = newCell;
        }
        public bool TryMovePlayer(int x, int y)
        {
            int newX = player.X + x;
            int newY = player.Y + y;
            Cell targetCell = cells[newX, newY];

            if (!targetCell.IsWalkable)
            {
                return false;
            }
            if (targetCell is CellDoor && player.keyCount <= 0)
            {
                return false;
            }

            // swap player position
            cells[player.X, player.Y] = CellFactory.CreateCell(CellType.Empty);
            player.Move(x, y);
            targetCell.OnEnter(this, player);
            cells[player.X, player.Y] = CellFactory.CreateCell(CellType.Player);

            return true;
        }
    }
}
