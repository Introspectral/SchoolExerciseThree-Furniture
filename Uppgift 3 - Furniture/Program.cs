namespace Uppgift_3___Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Table> tables;
            var table_1 = new Table() { Fabric=false, Name="Table_1", Steel=false, Wood=true, TypeOfFurniture=TypeOfFurniture.Bord, AreaOfTable=42};

            tables = new List<Table>();
            tables.Add(table_1);

            Console.WriteLine(tables[0]);    
        }
    }
}