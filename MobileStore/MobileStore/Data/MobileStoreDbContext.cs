using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MobileStore.Data.Models;

namespace MobileStore 
{
    public partial class MobileStoreDbContext : IdentityDbContext<IdentityUser>
    {
        public MobileStoreDbContext(DbContextOptions<MobileStoreDbContext> options) : base(options)
        {
        }

        public DbSet<Phone> Phones { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<ShoppingCart> ShoppingCart { get; set; }
    }
}