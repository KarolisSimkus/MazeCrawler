using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeCrawler
{
    static class CellFactory
    {
        public static Cell CreateCell(CellType type)
        {
            return type switch
            {
                CellType.Wall => new CellWall(),
                CellType.Key => new CellKey(),
                CellType.Danger => new CellDanger(),
                CellType.Door => new CellDoor(),
                CellType.Win => new CellWin(),
                CellType.Player => new CellPlayer(),
                CellType.Empty => new CellEmpty(),
                _ => throw new NotImplementedException()
            };
        }
    }
}
