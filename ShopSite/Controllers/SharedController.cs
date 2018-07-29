using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ShopSite.Controllers
{
    public class SharedController : Controller
    {
        public IActionResult _MasterPage()
        {
            ViewBag.Title = "Головна сторінка123";
            return View();
        }
    }
}