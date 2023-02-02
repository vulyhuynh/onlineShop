using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Models.Framework
{
    public partial class OnlineShopDbContext : DbContext
    {
        public OnlineShopDbContext()
            : base("name=OnlineShopDbContext")
        {
        }

        public virtual DbSet<tblAccount> tblAccounts { get; set; }
        public virtual DbSet<tblCategory> tblCategories { get; set; }
        public virtual DbSet<tblProduct> tblProducts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblAccount>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<tblAccount>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<tblCategory>()
                .Property(e => e.Alias)
                .IsUnicode(false);

            modelBuilder.Entity<tblProduct>()
                .Property(e => e.Alias)
                .IsUnicode(false);

            modelBuilder.Entity<tblProduct>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);
        }
    }
}
