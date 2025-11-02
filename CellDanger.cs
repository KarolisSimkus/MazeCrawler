namespace MazeCrawler
{
    internal class CellDanger : Cell
    {
        public override char drawCell() => '~';

        public override void OnEnter(Map map, CellPlayer player)
        {
            map.isAlive = false;
        }
    }
}