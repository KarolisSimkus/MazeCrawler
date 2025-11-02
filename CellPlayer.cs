using MazeCrawler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeCrawler
{
    class CellPlayer : Cell
    {
        public int X {  get; set; }
        public int Y { get; set; }
        public int keyCount { get; set; }
        public int doorCount { get; set; }

        public CellPlayer(int x, int y)
        {
            X = x;
            Y = y;
            keyCount = 0;
            doorCount = 0;
        }

        public CellPlayer()
        {
            X = 0;
            Y = 0;
            keyCount = 0;
            doorCount = 0;
        }
        public void addKey()
        {
            keyCount++;
        }
        public void addDoor()
        {
            doorCount++;
        }
        public void Move(int x, int y)
        {
            X += x;
            Y += y;
        }

        public override char drawCell() => '@';
    }
}
