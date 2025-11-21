namespace MazeCrawler
{
    internal class CellEmpty : Cell
    {
        public override char drawCell() => IsSeen ? ' ' : 'F';
    }
}