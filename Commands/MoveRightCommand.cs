using MazeCrawler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeCrawler
{
    internal class MoveRightCommand : ICommand
    {
        public void Execute(Map map)
        {
            map.TryMovePlayer(0, 1);
        }
    }
}
