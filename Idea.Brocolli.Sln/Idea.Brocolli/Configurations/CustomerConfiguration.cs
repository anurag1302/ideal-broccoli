using Idea.Brocolli.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Idea.Brocolli.Configurations;

public class CustomerConfiguration:IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.ToTable("customers");
        
        builder.HasKey(c=>c.Id);
        
        builder.Property(c => c.Id)
            .HasColumnName("id")
            .UseIdentityAlwaysColumn();
        
        builder.Property(c => c.FirstName)
            .HasColumnName("first_name")
            .HasMaxLength(100)
            .IsRequired();
        
        builder.Property(c => c.LastName)
            .HasColumnName("last_name")
            .HasMaxLength(100)
            .IsRequired();
        
        builder.Property(c => c.Email)
            .HasColumnName("email")
            .HasMaxLength(255)
            .IsRequired();

        builder.Property(c => c.CreatedAt)
            .HasColumnName("created_at")
            .HasColumnType("timestamp with time zone")
            .HasDefaultValueSql("NOW()");
    }
}