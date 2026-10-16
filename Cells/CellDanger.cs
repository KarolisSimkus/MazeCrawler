namespace MazeCrawler
{
    public class CellDanger : Cell
    {
        public override char DrawCell() => IsSeen ? '~' : 'F';

        public override void OnEnter(Map map, CellPlayer player)
        {
            map.IsAlive = false;
        }
    }
}