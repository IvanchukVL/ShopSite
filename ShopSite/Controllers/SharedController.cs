using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BLShopSite;

namespace ShopSite.Controllers
{
    public class SharedController : Controller
    {
        public IActionResult _MasterPage()
        {
            ViewBag.Title = "Головна сторінка123";
            return View();
        }

        //public IActionResult Menu()
        //{
        //    ViewBag.Menu = MenuMethod.GetMenuItems(1);
        //    return PartialView();
        //}
    }
}