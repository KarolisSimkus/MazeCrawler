namespace MazeCrawler
{
    public class CellEmpty : Cell
    {
        public override char DrawCell() => IsSeen ? ' ' : 'F';
    }
}