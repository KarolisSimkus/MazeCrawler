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

        public CellPlayer(int x, int y)
        {
            X = x;
            Y = y;
        }

        public CellPlayer()
        {
        }

        public void Move(int x, int y)
        {
            X += x;
            Y += y;
        }

        public override char drawCell() => '@';
    }
}
