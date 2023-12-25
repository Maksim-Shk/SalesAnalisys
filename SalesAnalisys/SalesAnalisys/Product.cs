namespace SalesAnalysis;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public double Price { get; set; }
    public double Total { get; set; }
    public int Cluster { get; set; }
}
