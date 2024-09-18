using FlavourlinesWebApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : IdentityDbContext<User>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // DbSets for other entities
    public DbSet<CustomerOrder> CustomerOrders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Payment> Payments { get; set; }

    public DbSet<Product> Product { get; set; }
    public DbSet<Category> Category { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder); // Important: Call the base method

        // Configure CustomerOrder primary key
        modelBuilder.Entity<CustomerOrder>()
            .HasKey(c => c.CustomerOrderId);

        modelBuilder.Entity<Product>()
            .HasKey(p => p.ProductId);

        modelBuilder.Entity<Category>()
            .HasKey(c => c.CategoryId);

        // Additional configurations if needed
        modelBuilder.Entity<CustomerOrder>()
            .HasOne(c => c.Payment)
            .WithOne(p => p.CustomerOrder)
            .HasForeignKey<Payment>(p => p.CustomerOrderId);
    }
}