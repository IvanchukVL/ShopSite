using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DBShopSite.Entities;
using BLShopSite;

namespace ShopSite.Controllers
{

    public class RecipeInformation
    {
        public string name { get; set; }
    }

    public class TovarsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListTovar(int? Id, int? TovarGroupId)
        {
            ViewBag.Id = Id;
            ViewBag.TovarGroupId = TovarGroupId;
            ViewBag.ListFilter = TovarMethods.GetFiltersForTovars(null, TovarGroupId);
            return View();
        }

        [HttpPost]
        public IActionResult MessageHandler([FromBody] RecipeInformation information)
        {
            var t = Request.Body;
            string result = "Вийшло!!!";
            return Json(result);
        }
    }
}