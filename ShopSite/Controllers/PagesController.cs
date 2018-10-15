using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DBShopSite.Entities;
using DBShopSite.Context;
using BLShopSite;
using Microsoft.Extensions.DependencyInjection;

namespace ShopSite.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult Main()
        {
            return View();
        }
        public IActionResult Proba(int? Id)
        {
            ViewBag.Id = Id;
            return View();
        }
    }
}