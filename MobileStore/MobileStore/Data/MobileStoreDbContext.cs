using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MobileStore.Data.Models;

namespace MobileStore
{
    public partial class MobileStoreDbContext : DbContext
    {
        public MobileStoreDbContext(DbContextOptions<MobileStoreDbContext> options) : base(options)
        {
        }

        public DbSet<Phone> Phones { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}