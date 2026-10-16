namespace MazeCrawler
{
    public class CellDoor : Cell
    {
        public override char DrawCell() => IsSeen ? 'O' : 'F';
        public override void OnEnter(Map map, CellPlayer player)
        {
            player.AddDoor();
            player.KeyCount--;
        }
    }
}