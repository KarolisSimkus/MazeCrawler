using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeCrawler
{
    static class CellFactory
    {
        private static Random rand = new Random();

        public static Cell CreateCell(CellType type)
        {
            switch (type)
            {
                case CellType.Wall:
                    return new CellWall();   
                case CellType.Empty:
                    return new CellEmpty();
                case CellType.Danger:
                    return new CellDanger();   
                case CellType.Door:
                    return new CellDoor();   
                case CellType.Key:
                    return new CellKey();   
            }
            //Bad
            throw new NotImplementedException();
            
        }
    }
}
