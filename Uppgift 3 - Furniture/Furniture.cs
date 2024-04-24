namespace Uppgift_3___Furniture
{
    public enum TypeOfFurniture
    {
        Bord,
        Stol,
        Taklampa,
        Bordslampa,
        Skrivbord
    }
    internal class Furniture
    {
        public bool Wood { get; set; }
        public bool Steel { get; set; }
        public bool Fabric { get; set; }
        public string? Name { get; set; }

        public TypeOfFurniture TypeOfFurniture { get; set; }
    }
}
