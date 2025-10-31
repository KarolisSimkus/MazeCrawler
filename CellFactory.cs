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

        public static Cell CreateCell(int row, int col)
        {
            char[] possibleSymbols = { '.', '#', '~' };
            char chosenSymbol = possibleSymbols[rand.Next(possibleSymbols.Length)];

            return new Cell(chosenSymbol);
        }
    }
}
