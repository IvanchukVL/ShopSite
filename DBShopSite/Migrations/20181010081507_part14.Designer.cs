﻿// <auto-generated />
using System;
using DBShopSite.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DBShopSite.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20181010081507_part14")]
    partial class part14
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("DBShopSite.Entities.Filter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(70);

                    b.Property<int>("Status");

                    b.Property<int>("TypeFilter");

                    b.HasKey("Id");

                    b.ToTable("Filters");
                });

            modelBuilder.Entity("DBShopSite.Entities.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<string>("Command")
                        .HasMaxLength(32);

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.Property<int>("ParentId");

                    b.Property<int>("Status");

                    b.Property<int?>("TovarGroupId");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("Menu");

                    b.HasData(
                        new { Id = 1, Code = "main", Command = "Main", Name = "Головна", ParentId = 0, Status = 1 },
                        new { Id = 2, Code = "Rods", Command = "", Name = "Вудилища", ParentId = 0, Status = 1 },
                        new { Id = 3, Code = "Reels", Command = "", Name = "Катушки", ParentId = 0, Status = 1 },
                        new { Id = 4, Code = "Accessories", Command = "", Name = "Аксесуари", ParentId = 0, Status = 1 },
                        new { Id = 5, Code = "FeederRods", Command = "FeederRods", Name = "Фідерні удилища", ParentId = 2, Status = 1 },
                        new { Id = 6, Code = "SpiningRods", Command = "SpiningRods", Name = "Спінінгові удилища", ParentId = 2, Status = 1 },
                        new { Id = 7, Code = "FeederReels", Command = "FeederReels", Name = "Фідерні катушки", ParentId = 3, Status = 1 },
                        new { Id = 8, Code = "FloadReels", Command = "FloadReels", Name = "Поплавочні катушки", ParentId = 3, Status = 1 },
                        new { Id = 9, Code = "SpiningReels", Command = "SpiningReels", Name = "Спінінгові катушки", ParentId = 3, Status = 1 },
                        new { Id = 10, Code = "FeederReelsBT", Command = "FeederReelsBT", Name = "З бертранером", ParentId = 7, Status = 1 },
                        new { Id = 11, Code = "FeederReelsWBT", Command = "FeederReelsWBT", Name = "Без бертранером", ParentId = 7, Status = 1 }
                    );
                });

            modelBuilder.Entity("DBShopSite.Entities.Roles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("RoleCode");

                    b.Property<string>("RoleName");

                    b.Property<int?>("Status");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new { Id = 1, RoleCode = "Admin", RoleName = "Адміністратор", Status = 1 },
                        new { Id = 2, RoleCode = "Guest", RoleName = "Гість", Status = 1 },
                        new { Id = 3, RoleCode = "Client", RoleName = "Клієнт", Status = 1 }
                    );
                });

            modelBuilder.Entity("DBShopSite.Entities.RolesMenu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MenuId");

                    b.Property<int>("RoleId");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.HasIndex("RoleId");

                    b.ToTable("RolesMenu");

                    b.HasData(
                        new { Id = 1, MenuId = 1, RoleId = 1, Status = 1 },
                        new { Id = 2, MenuId = 2, RoleId = 1, Status = 1 },
                        new { Id = 3, MenuId = 3, RoleId = 1, Status = 1 },
                        new { Id = 4, MenuId = 4, RoleId = 1, Status = 1 },
                        new { Id = 5, MenuId = 5, RoleId = 1, Status = 1 },
                        new { Id = 6, MenuId = 6, RoleId = 1, Status = 1 },
                        new { Id = 7, MenuId = 7, RoleId = 1, Status = 1 },
                        new { Id = 8, MenuId = 8, RoleId = 1, Status = 1 },
                        new { Id = 9, MenuId = 9, RoleId = 1, Status = 1 },
                        new { Id = 10, MenuId = 10, RoleId = 1, Status = 1 },
                        new { Id = 11, MenuId = 11, RoleId = 1, Status = 1 }
                    );
                });

            modelBuilder.Entity("DBShopSite.Entities.Tovar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("GroupId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("Tovars");
                });

            modelBuilder.Entity("DBShopSite.Entities.TovarGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FilterId");

                    b.Property<string>("NameGroup")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("TovarGroups");
                });

            modelBuilder.Entity("DBShopSite.Entities.TovarGroupFilter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FilterId");

                    b.Property<int>("Status");

                    b.Property<int>("TovarGroupId");

                    b.HasKey("Id");

                    b.ToTable("TovarGroupFilters");
                });

            modelBuilder.Entity("DBShopSite.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comment")
                        .HasMaxLength(250);

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70);

                    b.Property<int?>("Status")
                        .IsRequired();

                    b.Property<string>("eMail")
                        .HasMaxLength(70);

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new { Id = 1, Login = "Guest", Name = "Гість", Status = 1 },
                        new { Id = 2, Login = "VIvanchuk", Name = "Іванчук Володимир Львович", Status = 1 }
                    );
                });

            modelBuilder.Entity("DBShopSite.Entities.UsersRoles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("RoleId");

                    b.Property<int>("Status");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UsersRoles");

                    b.HasData(
                        new { Id = 1, RoleId = 1, Status = 1, UserId = 1 }
                    );
                });

            modelBuilder.Entity("DBShopSite.Entities.RolesMenu", b =>
                {
                    b.HasOne("DBShopSite.Entities.Menu")
                        .WithMany("MenusRoles")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DBShopSite.Entities.Roles")
                        .WithMany("RolesMenu")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DBShopSite.Entities.UsersRoles", b =>
                {
                    b.HasOne("DBShopSite.Entities.User")
                        .WithMany("UsersRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
