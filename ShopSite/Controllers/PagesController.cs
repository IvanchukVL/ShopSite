using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DBShopSite;

namespace ShopSite.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult Main()
        {
            ViewBag.Title1 = "Головна сторінка12345";
            using (ApplicationContext db = new ApplicationContext())
            {
                User user1 = new User { Id = 1, Name = "Tom", Age = 33 };
                User user2 = new User { Id = 2, Name = "Alice", Age = 26 };

                // добавляем их в бд
                db.Users.Add(user1);
                db.Users.Add(user2);
                db.SaveChanges();
            }
            return View();
        }
    }
}