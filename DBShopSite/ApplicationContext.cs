using System;
using Microsoft.EntityFrameworkCore;

namespace DBShopSite
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public string Conn { get; set; }

        public ApplicationContext() : base()
        {
            Conn = "Host=localhost;Port=5432;Database=Proba;Username=postgres;Password=1";
        }
        public ApplicationContext(string tConn) : base()
        {
            Conn = tConn;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Proba;Username=postgres;Password=1");
        }
    }
}
