using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeCrawler
{
    internal class CellWin : Cell
    {
        public override char drawCell() => 'X';

        public override void OnEnter(Map map, CellPlayer player)
        {
            //Console.WriteLine("IN CELLWIN OnEnter Method");
            map.isWin = true;
        }
    }
}
