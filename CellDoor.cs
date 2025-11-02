namespace MazeCrawler
{
    internal class CellDoor : Cell
    {
        public override char drawCell() => 'O';
        public override void OnEnter(Map map, CellPlayer player)
        {
            player.addDoor();
            player.keyCount--;
        }
    }
}