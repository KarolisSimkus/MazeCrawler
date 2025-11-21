namespace MazeCrawler
{
    public class CellEmpty : Cell
    {
        public override char drawCell() => IsSeen ? ' ' : 'F';
    }
}