namespace Uppgift_3___Furniture
{
    internal class Lamp : Furniture
    {
        public double Current { get; set; }
        public override string ToString()
        {
            return $"Lampan {Name} drar {Current} amp";
        }
    }
}
