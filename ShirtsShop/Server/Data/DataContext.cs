using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShirtsShop.Shared;

namespace ShirtsShop.Server.Data 
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Size>().HasData(
                new Size { Id = 1, Name = "XS"},
                new Size { Id = 2, Name = "S"},
                new Size { Id = 3, Name = "XM"},
                new Size { Id = 4, Name = "M"},
                new Size { Id = 5, Name = "L"},
                new Size { Id = 6, Name = "XL"},
                new Size { Id = 7, Name = "XXL"},
                new Size { Id = 8, Name = "XXXL"},
                new Size { Id = 9, Name = "XXXXL"}
            );
            modelBuilder.Entity<Shirt>().HasData(
                new Shirt { Id = 1, Color = "Black", Text = "Long", SizeId = 2 },
                new Shirt { Id = 2, Color = "White", Text = "Live", SizeId = 4 }
            );
        }

        public DbSet<Shirt> Shirts { get; set; }

        public DbSet<Size> Sizes { get; set; }
    }
}