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

        public static readonly string[] map =
    {
        "##########",
        "#....D...#",
        "#....D.W.#",
        "#....X...#",
        "#....DDDD#",
        "#.K......#",
        "#........#",
        "#....#####",
        "#....X.K.#",
        "##########"
    };

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
            printAllMap();
            printBottomLegend();
        }
        private void printAllMap()
        {
            for (int i = player.X - 1; i < player.X + 2; i++)
            {
                for (int j = player.Y - 1; j < player.Y + 2; j++)
                {
                    cells[i,j].IsSeen = true;
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
        public void setMap()
        {
            for (int i = 0; i < mapRows; i++)
            {
                for (int j = 0; j < mapCols; j++)
                {
                    Console.WriteLine("MAPCOLS:" + j + " MAPROWS:" + i);
                    char symbol = map[i][j];
                    CellType type = symbol switch
                    {
                        '#' => CellType.Wall,
                        'K' => CellType.Key,
                        'D' => CellType.Danger,
                        'X' => CellType.Door,
                        'W' => CellType.Win,
                        'P' => CellType.Player,
                        '.' => CellType.Empty,
                        _ => throw new NotImplementedException()
                    };

                    cells[i, j] = CellFactory.CreateCell(type);
                }
            }
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

            cells[player.X, player.Y] = CellFactory.CreateCell(CellType.Empty);
            player.Move(x, y);
            targetCell.OnEnter(this, player);
            cells[player.X, player.Y] = CellFactory.CreateCell(CellType.Player);

            return true;
        }
    }
}
