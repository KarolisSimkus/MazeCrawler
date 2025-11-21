namespace MazeCrawler
{
    public class CellDoor : Cell
    {
        public override char drawCell() => IsSeen ? 'O' : 'F';
        public override void OnEnter(Map map, CellPlayer player)
        {
            player.addDoor();
            player.keyCount--;
        }
    }
}