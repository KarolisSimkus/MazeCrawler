using MazeCrawler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeCrawler
{
    internal class CellWall : Cell
    {
        public override char drawCell() => IsSeen ? '#' : 'F';

        public override bool IsWalkable => false;
    }
}
