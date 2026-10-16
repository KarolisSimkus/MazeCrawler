using MazeCrawler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeCrawler
{
    public class CellPlayer : Cell
    {
        public int X {  get; set; }
        public int Y { get; set; }
        public int KeyCount { get; set; }
        public int DoorCount { get; set; }

        

        public CellPlayer(int x, int y)
        {
            X = x;
            Y = y;
            KeyCount = 0;
            DoorCount = 0;
        }

        public CellPlayer()
        {
            X = 0;
            Y = 0;
            KeyCount = 0;
            DoorCount = 0;
        }
        public void AddKey()
        {
            KeyCount++;
        }
        public void AddDoor()
        {
            DoorCount++;
        }
        public void Move(int x, int y)
        {
            X += x;
            Y += y;
        }

        public override char DrawCell() => '@';
    }
}
