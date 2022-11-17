using Microsoft.EntityFrameworkCore;
using ShopeeFake.Models;

namespace ShopeeFake.Data
{
    public class ShopeeFakeDbContex : DbContext
    {
        public ShopeeFakeDbContex(DbContextOptions<ShopeeFakeDbContex> options) : base(options)
        {
        }

        public virtual DbSet<AppRole> AppRoles { get; set; } = null!;
        public virtual DbSet<Cart> Carts { get; set; } = null!;
        public virtual DbSet<CartDetail> CartDetails { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Rate> Rates { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppRole>(entity =>
            {
                entity.ToTable("AppRole");
                entity.HasKey(ar => ar.AppRoleId);
                entity.Property(ar => ar.AppRoleId).UseIdentityColumn();
                entity.Property(ar => ar.RoleName).IsRequired();
            });
            modelBuilder.Entity<Cart>(entity =>
            {
                entity.ToTable("Cart");
                entity.HasKey(c => c.CartId);
                entity.Property(c => c.CartId).UseIdentityColumn();
                entity.Property(c => c.Amount).HasColumnType("money");
                entity.Property(c => c.Address).IsRequired().HasMaxLength(255);
                entity.Property(c => c.Phone).IsRequired().HasMaxLength(10);
                entity.HasOne(u => u.User).WithMany(c => c.Carts).HasForeignKey(u => u.UserId).OnDelete(DeleteBehavior.Cascade);
            });
            modelBuilder.Entity<CartDetail>(entity =>
            {
                entity.ToTable("CartDetail");
                entity.HasKey(cd => cd.CartDetailId);
                entity.Property(cd => cd.CartDetailId).UseIdentityColumn();
                entity.Property(cd => cd.Price).HasColumnType("money");
                entity.HasOne(p => p.Product).WithMany(cd => cd.CartDetails).HasForeignKey(p => p.ProductId).OnDelete(DeleteBehavior.Cascade);
            });
            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");
                entity.HasKey(c => c.CategoryId);
                entity.Property(c => c.CategoryId).UseIdentityColumn();
                entity.Property(c => c.CategoryName).IsRequired();
            });
            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");
                entity.HasKey(o => o.OrderId);
                entity.Property(o => o.OrderId).UseIdentityColumn();
                entity.Property(o => o.Amount).HasColumnType("money");
                entity.Property(o => o.Address).IsRequired().HasMaxLength(255);
                entity.Property(o => o.Phone).IsRequired().HasMaxLength(10);
                entity.Property(o => o.Status).HasDefaultValue(true);
                entity.HasOne(u => u.User).WithMany(o => o.Orders).HasForeignKey(u => u.UserId).OnDelete(DeleteBehavior.Cascade);
            });
            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.ToTable("OrderDetail");
                entity.HasKey(od => od.OrderDetailId);
                entity.Property(od => od.OrderDetailId).UseIdentityColumn();
                entity.Property(od => od.Price).HasColumnType("money");
                entity.HasOne(p => p.Product).WithMany(od => od.OrderDetails).HasForeignKey(p => p.ProductId).OnDelete(DeleteBehavior.Cascade);
                entity.HasOne(o => o.Order).WithMany(od => od.OrderDetails).HasForeignKey(o => o.OrderId).OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");
                entity.HasKey(p => p.ProductId);
                entity.Property(p => p.ProductId).UseIdentityColumn();
                entity.Property(p => p.ProductName).IsRequired().HasMaxLength(100);
                entity.Property(p => p.Description).HasMaxLength(1000);
                entity.Property(p => p.Price).HasColumnType("money");
                entity.Property(p => p.Status).HasDefaultValue(true);
                entity.HasOne(c => c.Category).WithMany(p => p.Products).HasForeignKey(c => c.CategoryId).OnDelete(DeleteBehavior.Cascade);
            });
            modelBuilder.Entity<Rate>(entity =>
            {
                entity.ToTable("Rate");
                entity.HasKey(r => r.RateId);
                entity.Property(r => r.RateId).UseIdentityColumn();
                entity.Property(r => r.Comment).HasMaxLength(255);
                entity.HasOne(u => u.User).WithMany(r => r.Rates).HasForeignKey(u => u.UserId).OnDelete(DeleteBehavior.Cascade);
                entity.HasOne(p => p.Product).WithMany(r => r.Rates).HasForeignKey(p => p.ProductId).OnDelete(DeleteBehavior.Cascade);
            });
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");
                entity.HasKey(u => u.UserId);
                entity.Property(u => u.UserId).UseIdentityColumn();
                entity.Property(u => u.Password).IsRequired();
                entity.Property(u => u.Email).IsRequired().HasMaxLength(200);
                entity.Property(u => u.Phone).HasMaxLength(10);
                entity.Property(u => u.UserName).HasMaxLength(25);
                entity.Property(u => u.Status).HasDefaultValue(true);
                entity.HasOne(ur => ur.AppRole).WithMany(u => u.Users).HasForeignKey(ur => ur.AppRoleId).OnDelete(DeleteBehavior.Cascade);
            });
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seedings();
        }
    }
}