using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Models;

#nullable disable

namespace Proj0DBContext
{
    public partial class Project0Context : DbContext
    {
        public Project0Context()
        {
        }

        public Project0Context(DbContextOptions<Project0Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<LocationDirectory> LocationDirectories { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Store> Stores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Project0;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.CustomerCityt).HasMaxLength(60);

                entity.Property(e => e.CustomerEmail)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.CustomerFirstName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerLastName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerPassWord)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerState).HasMaxLength(2);

                entity.Property(e => e.CustomerStreet).HasMaxLength(60);

                entity.Property(e => e.CustomerUserName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.CustomerStoreNavigation)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.CustomerStore)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CustomerStore");
            });

            modelBuilder.Entity<LocationDirectory>(entity =>
            {
                entity.HasKey(e => e.StoreId)
                    .HasName("PK__Location__3B82F1015E075961");

                entity.ToTable("LocationDirectory");

                entity.Property(e => e.StoreCitytAd)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.StoreName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.StoreStateAd)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.StoreStreetAd)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.Tracking)
                    .HasName("PK__Orders__51CB84C295E45A23");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("OrderID");

                entity.Property(e => e.OrderStoreId).HasColumnName("OrderStoreID");

                entity.HasOne(d => d.OrderAccount)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.OrderAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK1");

                entity.HasOne(d => d.OrderProduct)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.OrderProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK2");

                entity.HasOne(d => d.OrderNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => new { d.OrderStoreId, d.OrderProductId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PFK");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.Department).HasMaxLength(200);

                entity.Property(e => e.ProductDescription).HasMaxLength(200);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ProductPrice).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.HasKey(e => new { e.StoreLocation, e.StoreProduct })
                    .HasName("PK__Store__EF983EDEE86AEBFF");

                entity.ToTable("Store");

                entity.HasOne(d => d.StoreLocationNavigation)
                    .WithMany(p => p.Stores)
                    .HasForeignKey(d => d.StoreLocation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("StoreLocation");

                entity.HasOne(d => d.StoreProductNavigation)
                    .WithMany(p => p.Stores)
                    .HasForeignKey(d => d.StoreProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("StoreProduct");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
