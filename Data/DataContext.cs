using EfCoreDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreDemo.Data
{
    public class DataContext : DbContext
    { 
        public DbSet<ShopItem> ShopItems { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<ItemTag> ItemTag { get; set; }
        public DbSet<ShopItemItemTag> ShopItemItemTags { get; set; }

        public DataContext(DbContextOptions options) : base(options)
        {

        }
       
        protected override void OnModelCreating(ModelBuilder modelBuider)
        {
            modelBuider.Entity<ShopItem>()
                .Property(b => b.Price)
                .HasPrecision(20, 2);

            modelBuider.Entity<Shop>()
                .HasMany(s => s.ShopItems)
                .WithOne(si => si.Shop);

            modelBuider.Entity<ShopItemItemTag>()
                .HasKey(bc => new { bc.ShopItemId, bc.TagId });
        }
    }
}
