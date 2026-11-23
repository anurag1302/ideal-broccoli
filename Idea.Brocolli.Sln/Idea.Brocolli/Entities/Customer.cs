namespace Idea.Brocolli.Entities;

public class Customer
{
    public long Id { get; set; }

    public string? FirstName { get; set; } = null!;

    public string? LastName { get; set; } = null!;

    public string? Email { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    // Navigation property
    public ICollection<Order> Orders { get; set; }
        = new List<Order>();
}