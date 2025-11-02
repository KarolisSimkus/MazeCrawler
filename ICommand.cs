using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeCrawler
{
    internal interface ICommand
    {
        void Execute(Map map);
    }
}
