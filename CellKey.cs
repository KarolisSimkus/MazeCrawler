using System.Numerics;

namespace MazeCrawler
{
    internal class CellKey : Cell
    {
        public override char drawCell() => '+';
        public override void OnEnter(Map map, CellPlayer player)
        {
            player.addKey();
            Console.WriteLine("You picked up a key! Total keys: " + player.keyCount);
            // Replace the cell with empty after picking up
            //map.ReplaceCell(player.X, player.Y, new EmptyCell());
        }
    }
}