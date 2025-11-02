using MazeCrawler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeCrawler
{
    internal class MoveDownCommand : ICommand
    {
        public void Execute(Map m)
        {
            m.TryMovePlayer(1, 0);
        }
    }
}
