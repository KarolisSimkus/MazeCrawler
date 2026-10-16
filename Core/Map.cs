using MazeCrawler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeCrawler
{
    public class Map
    {
        public int MapRows { get; init; }
        public int MapCols { get; init; }
        public bool IsAlive = true;
        public bool IsWin = false;

        public static readonly string[] MapData =
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

        private readonly Cell[,] _cells;
        private readonly CellPlayer _player;

        public Map(int mapRows, int mapCols)
        {
            MapRows = mapRows;
            MapCols = mapCols;
            _cells = new Cell[mapRows, mapCols];
            _player = new CellPlayer(3, 3);
        }
        private void PrintTopLegend()
        {
            Console.WriteLine("[w,a,s,d]");
        }
        private void PrintBottomLegend()
        {
            Console.WriteLine("Keycount:" + _player.KeyCount);
            Console.WriteLine("Doors Opened:" + _player.DoorCount);
        }
        public void Draw()
        {
            PrintTopLegend();
            PrintAllMap();
            PrintBottomLegend();
        }
        private void PrintAllMap()
        {
            for (int i = _player.X - 1; i < _player.X + 2; i++)
            {
                for (int j = _player.Y - 1; j < _player.Y + 2; j++)
                {
                    _cells[i,j].IsSeen = true;
                }
            }
            for (int i = 0; i < MapRows; i++)
            {
                for (int j = 0; j < MapCols; j++)
                {
                    Console.Write("[" + _cells[i, j].DrawCell() + "]");
                }
                Console.WriteLine();
            }
        }
        public void SetMap()
        {
            for (int i = 0; i < MapRows; i++)
            {
                for (int j = 0; j < MapCols; j++)
                {
                    Console.WriteLine("MAPCOLS:" + j + " MAPROWS:" + i);
                    char symbol = MapData[i][j];
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

                    _cells[i, j] = CellFactory.CreateCell(type);
                }
            }
        }
        public void ReplaceCell(int x, int y, Cell newCell)
        {
            _cells[x, y] = newCell;
        }
        public bool TryMovePlayer(int x, int y)
        {
            int newX = _player.X + x;
            int newY = _player.Y + y;
            Cell targetCell = _cells[newX, newY];

            if (!targetCell.IsWalkable)
            {
                return false;
            }
            if (targetCell is CellDoor && _player.KeyCount <= 0)
            {
                return false;
            }

            _cells[_player.X, _player.Y] = CellFactory.CreateCell(CellType.Empty);
            _player.Move(x, y);
            targetCell.OnEnter(this, _player);
            _cells[_player.X, _player.Y] = CellFactory.CreateCell(CellType.Player);

            return true;
        }
    }
}
