namespace MazeCrawler
{
    public class CellDanger : Cell
    {
        public override char drawCell() => IsSeen ? '~' : 'F';

        public override void OnEnter(Map map, CellPlayer player)
        {
            map.isAlive = false;
        }
    }
}