using MazeCrawler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_MazeCrawler
{
    internal class MoveUpCommand : ICommand
    {
        public void Execute(Map m)
        {
            m.TryMovePlayer(-1, 0);
        }
    }
}
