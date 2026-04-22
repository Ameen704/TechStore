using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TechStore.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Product> Products => Set<Product>();
        public DbSet<Category> Categories => Set<Category>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Price).HasColumnType("decimal(10,2)");
                entity.HasOne(p => p.Category)
                      .WithMany(c => c.Products)
                      .HasForeignKey(p => p.CategoryId)
                      .OnDelete(DeleteBehavior.Restrict);
            });

            builder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasIndex(e => e.Name).IsUnique();
            });

            builder.Entity<Category>(e =>
            {
                e.Property(x => x.CreatedAt).HasDefaultValueSql("GETUTCDATE()");
                e.Property(x => x.UpdatedAt).HasDefaultValueSql("GETUTCDATE()");
            });
            builder.Entity<Product>(e =>
            {
                e.Property(x => x.CreatedAt).HasDefaultValueSql("GETUTCDATE()");
                e.Property(x => x.UpdatedAt).HasDefaultValueSql("GETUTCDATE()");
            });

            // Seed data
            builder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Electronics", Description = "General tech devices", IsActive = true },
                new Category { Id = 2, Name = "Laptops", Description = "Notebooks and ultrabooks", IsActive = true },
                new Category { Id = 3, Name = "Smartphones", Description = "Android and iOS phones", IsActive = true },
                new Category { Id = 4, Name = "Accessories", Description = "Headphones, keyboards, etc.", IsActive = true },
                new Category { Id = 5, Name = "Components", Description = "CPUs, GPUs, RAM, SSDs", IsActive = true }
            );
        }
    }
}
