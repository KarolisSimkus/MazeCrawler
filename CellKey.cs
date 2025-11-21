using System.Numerics;

namespace MazeCrawler
{
    public class CellKey : Cell
    {
        public override char drawCell() => IsSeen ? '+' : 'F';
        public override void OnEnter(Map map, CellPlayer player)
        {
            player.addKey();
        }
    }
}