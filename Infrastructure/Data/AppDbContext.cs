using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    
        public DbSet<Application_User> Users { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<ProductsCategories> categories { get; set; }
        public DbSet<CartItem> cartItems { get; set; }
        public DbSet<Cart> carts { get; set; }



    }
}
