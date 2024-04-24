namespace Uppgift_3___Furniture
{
    internal class Table : Furniture
    {
        public double AreaOfTable { get; set; }
        public override string ToString()
        {
            return $"Bordet {Name} har ytan {AreaOfTable}";
        }
    }
}
