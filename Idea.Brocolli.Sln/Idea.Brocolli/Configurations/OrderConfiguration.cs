using Idea.Brocolli.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Idea.Brocolli.Configurations;

public class OrderConfiguration:IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.ToTable("orders");
        
        builder.HasKey(c=>c.Id);
        
        builder.Property(c => c.Id)
            .HasColumnName("id")
            .UseIdentityAlwaysColumn();
        
        builder.Property(c => c.CustomerId)
            .HasColumnName("customer_id")
            .IsRequired();
        
        builder.Property(c => c.Status)
            .HasColumnName("status")
            .HasDefaultValue("PENDING")
            .IsRequired();

        builder.Property(c => c.CreatedAt)
            .HasColumnName("created_at")
            .HasColumnType("timestamp with time zone")
            .HasDefaultValueSql("NOW()");
        
        builder.HasOne(c => c.Customer)
            .WithMany(c => c.Orders)
            .HasForeignKey(c => c.CustomerId)
            .OnDelete(DeleteBehavior.Cascade);
        
    }
}