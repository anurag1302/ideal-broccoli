namespace Idea.Brocolli.Entities;

public class Product
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public int StockQuantity { get; set; }

    public DateTime CreatedAt { get; set; }

    public ICollection<OrderItem> OrderItems { get; set; }
        = new List<OrderItem>();
}