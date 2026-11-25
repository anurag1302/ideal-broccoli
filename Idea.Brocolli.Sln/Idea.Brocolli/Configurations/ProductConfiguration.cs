using Idea.Brocolli.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Idea.Brocolli.Configurations;

public class ProductConfiguration:IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("products");
        
        builder.HasKey(c => c.Id);

        builder.Property(c => c.Id)
            .HasColumnName("id")
            .UseIdentityAlwaysColumn();

        builder.Property(c => c.Name)
            .HasColumnName("name")
            .IsRequired();

        builder.Property(c => c.Description)
            .HasColumnName("description");

        builder.Property(c => c.Price)
            .HasColumnName("price")
            .HasPrecision(12,2)
            .IsRequired();
        
        builder.Property(c => c.StockQuantity)
            .HasColumnName("stock_quantity")
            .IsRequired();

        builder.Property(c => c.CreatedAt)
            .HasColumnName("created_at")
            .HasColumnType("timestamp with time zone")
            .HasDefaultValueSql("NOW()");
        
        
    }
}