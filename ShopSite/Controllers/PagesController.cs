using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DBShopSite.Entities;
using DBShopSite.Context;

namespace ShopSite.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult Main()
        {
            var optionsBuilder = new Microsoft.EntityFrameworkCore.DbContextOptionsBuilder<DataContext>();
            ViewBag.Title1 = "Головна сторінка12345";
            using (DataContext db = new DataContext())
            {
                User user1 = new User { Id = 5, Login = "Tom", Name="fff"};
                User user2 = new User { Id = 6, Login = "Alice", Name = "fff" };

                // добавляем их в бд
                db.Users.Add(user1);
                db.Users.Add(user2);
                db.SaveChanges();
            }
            return View();
        }
    }
}