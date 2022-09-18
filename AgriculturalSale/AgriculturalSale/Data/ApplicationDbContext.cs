using AgriculturalSale.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AgriculturalSale.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Definir Compuesta de SaleDetail
            builder.Entity<SaleDetail>().HasKey(sp => new
            {
                sp.ProductId,
                sp.SaleId
            });

            //traer foranea de product
            builder.Entity<SaleDetail>()
                .HasOne(p=>p.Product)
                .WithMany(sp=> sp.saleDetails)
                .HasForeignKey(p => p.ProductId);
            //traer foranea de sale
            builder.Entity<SaleDetail>()
                .HasOne(s => s.Sale)
                .WithMany(sp => sp.SaleDetails)
                .HasForeignKey(s => s.SaleId);

            base.OnModelCreating(builder);

        }
        public DbSet <ProductType> ProductType { get; set; }
        public DbSet <Location> Location { get; set; }
        public DbSet <Product> Product { get; set; }
        public DbSet <Sale> Sale { get; set; }
        public DbSet<SaleDetail> SaleDetail { get; set; }
        public DbSet <MethodOfPayment> MethodOfPayment { get; set; }

    }
}