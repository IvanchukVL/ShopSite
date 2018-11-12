using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ShopSite.Controllers
{
    public class TovarsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Tovars(int? Id, int? TovarGroupId)
        {
            ViewBag.Id = Id;
            ViewBag.TovarGroupId = TovarGroupId;
            return View();
        }

    }
}