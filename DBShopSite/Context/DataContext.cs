using System;
using Microsoft.EntityFrameworkCore;
using DBShopSite.Entities;

namespace DBShopSite.Context
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<MenuRole> MenuRole { get; set; }
        public string Conn { get; set; }

        public DataContext() : base()
        {
            //Conn = "Host=localhost;Port=5432;Database=ShopSite;Username=postgres;Password=1";
        }
        public DataContext(string tConn) : base()
        {
            Conn = tConn;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(Conn);
        }

        /// <summary>
        /// Першочергове заповнення даними (при створенні БД)
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<User>().HasData(new User { Id = 1, Login= "VIvanchuk1", Name = "Іванчук Володимир Львович" });
            modelBuilder.Entity<User>().HasData(new User { Id = 2, Login = "VIvanchuk2", Name = "Іванчук Володимир Львович" });
            modelBuilder.Entity<User>().HasData(new User { Id = 3, Login = "VIvanchuk3", Name = "Іванчук Володимир Львович" });
        }
    }
}
