namespace Idea.Brocolli.Entities;

public class Order
{
    public long Id { get; set; }

    public long CustomerId { get; set; }

    public DateTime CreatedAt { get; set; }

    public string Status { get; set; } = "PENDING";

    // Navigation property
    public Customer Customer { get; set; } = null!;

    public ICollection<OrderItem> Items { get; set; }
        = new List<OrderItem>();
}