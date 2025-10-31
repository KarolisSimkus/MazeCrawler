using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeCrawler
{
    internal class Cell
    {
        private char symbol = 'x';
        public char drawCell() 
        {
            return symbol;
        }

        public Cell(char symbol)
        {
            this.symbol = symbol;
        }
    }
}
