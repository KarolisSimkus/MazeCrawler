using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MazeCrawler
{
    abstract class Cell
    {
        public abstract char drawCell();
        public virtual bool IsWalkable => true;
        public virtual bool IsSeen { get; set; } = false;
        public virtual void OnEnter(Map map, CellPlayer player) { }
    }
}
