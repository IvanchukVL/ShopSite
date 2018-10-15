using System;
using Microsoft.EntityFrameworkCore;
using DBShopSite.Entities;
using System.ComponentModel;

namespace DBShopSite.Context
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<RolesMenu> RolesMenu { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<UsersRoles> UsersRoles { get; set; }
        public DbSet<TovarGroup> TovarGroups { get; set; }
        public DbSet<Tovar> Tovars { get; set; }
        public DbSet<Filter> Filters { get; set; }
        public DbSet<TovarGroupFilter> TovarGroupFilters { get; set; }
        public DbSet<FilterItems> FilterItems { get; set; }

        //[DefaultValue("Host=localhost;Port=5432;Database=ShopSite;Username=postgres;Password=1")]
        public string Conn { get; set; }



        //public DataContext(DbContextOptions options) : base(options)
        //{
        //    //Conn = "Host=localhost;Port=5432;Database=ShopSite;Username=postgres;Password=1";
        //}

        public DataContext() 
        {
            Conn = "Host=localhost;Port=5432;Database=ShopSite;Username=postgres;Password=1";
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
            
            modelBuilder.Entity<User>().HasData(new User { Id = 1, Login= "Guest", Name = "Гість", Status=1 });
            modelBuilder.Entity<User>().HasData(new User { Id = 2, Login = "VIvanchuk", Name = "Іванчук Володимир Львович", Status=1 });
            modelBuilder.Entity<Roles>().HasData(new Roles { Id = 1, RoleCode="Admin", RoleName="Адміністратор", Status=1 });
            modelBuilder.Entity<Roles>().HasData(new Roles { Id = 2, RoleCode = "Guest", RoleName = "Гість", Status = 1 });
            modelBuilder.Entity<Roles>().HasData(new Roles { Id = 3, RoleCode = "Client", RoleName = "Клієнт", Status = 1 });

            modelBuilder.Entity<Menu>().HasData(new Menu { Id = 1, ParentId = 0, Code = "main", Name = "Головна", Command = "Main", Status = 1 });
            modelBuilder.Entity<Menu>().HasData(new Menu { Id = 2, ParentId = 0, Code = "Rods", Name = "Вудилища", Command = "", Status = 1 });
            modelBuilder.Entity<Menu>().HasData(new Menu { Id = 3, ParentId = 0, Code = "Reels", Name = "Катушки", Command = "", Status = 1 });
            modelBuilder.Entity<Menu>().HasData(new Menu { Id = 4, ParentId = 0, Code = "Accessories", Name = "Аксесуари", Command = "", Status = 1 });
            modelBuilder.Entity<Menu>().HasData(new Menu { Id = 5, ParentId = 2, Code = "FeederRods", Name = "Фідерні удилища", Command = "FeederRods", Status = 1 });
            modelBuilder.Entity<Menu>().HasData(new Menu { Id = 6, ParentId = 2, Code = "SpiningRods", Name = "Спінінгові удилища", Command = "SpiningRods", Status = 1 });
            modelBuilder.Entity<Menu>().HasData(new Menu { Id = 7, ParentId = 3, Code = "FeederReels", Name = "Фідерні катушки", Command = "FeederReels", Status = 1 });
            modelBuilder.Entity<Menu>().HasData(new Menu { Id = 8, ParentId = 3, Code = "FloadReels", Name = "Поплавочні катушки", Command = "FloadReels", Status = 1 });
            modelBuilder.Entity<Menu>().HasData(new Menu { Id = 9, ParentId = 3, Code = "SpiningReels", Name = "Спінінгові катушки", Command = "SpiningReels", Status = 1 });
            modelBuilder.Entity<Menu>().HasData(new Menu { Id = 10, ParentId = 7, Code = "FeederReelsBT", Name = "З бертранером", Command = "FeederReelsBT", Status = 1 });
            modelBuilder.Entity<Menu>().HasData(new Menu { Id = 11, ParentId = 7, Code = "FeederReelsWBT", Name = "Без бертранером", Command = "FeederReelsWBT", Status = 1 });

            modelBuilder.Entity<RolesMenu>().HasData(new RolesMenu { Id = 1, MenuId=1, RoleId=1, Status=1 });
            modelBuilder.Entity<RolesMenu>().HasData(new RolesMenu { Id = 2, MenuId = 2, RoleId = 1, Status = 1 });
            modelBuilder.Entity<RolesMenu>().HasData(new RolesMenu { Id = 3, MenuId = 3, RoleId = 1, Status = 1 });
            modelBuilder.Entity<RolesMenu>().HasData(new RolesMenu { Id = 4, MenuId = 4, RoleId = 1, Status = 1 });
            modelBuilder.Entity<RolesMenu>().HasData(new RolesMenu { Id = 5, MenuId = 5, RoleId = 1, Status = 1 });
            modelBuilder.Entity<RolesMenu>().HasData(new RolesMenu { Id = 6, MenuId = 6, RoleId = 1, Status = 1 });
            modelBuilder.Entity<RolesMenu>().HasData(new RolesMenu { Id = 7, MenuId = 7, RoleId = 1, Status = 1 });
            modelBuilder.Entity<RolesMenu>().HasData(new RolesMenu { Id = 8, MenuId = 8, RoleId = 1, Status = 1 });
            modelBuilder.Entity<RolesMenu>().HasData(new RolesMenu { Id = 9, MenuId = 9, RoleId = 1, Status = 1 });
            modelBuilder.Entity<RolesMenu>().HasData(new RolesMenu { Id = 10, MenuId = 10, RoleId = 1, Status = 1 });
            modelBuilder.Entity<RolesMenu>().HasData(new RolesMenu { Id = 11, MenuId = 11, RoleId = 1, Status = 1 });

            modelBuilder.Entity<UsersRoles>().HasData(new UsersRoles { Id=1, UserId=1, RoleId=1, Status=1});

        }
    }
}
