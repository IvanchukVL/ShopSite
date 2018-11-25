using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DBShopSite.Entities;
using BLShopSite;

namespace ShopSite.Controllers
{

    public class Param
    {
        public string Id { get; set; }
        public string Value { get; set; }
    }

    public class TovarsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ReviewTovars(int? Id, int? TovarGroupId)
        {
            ViewBag.Id = Id;
            ViewBag.TovarGroupId = TovarGroupId;
            ViewBag.ListFilter = TovarMethods.GetFiltersForTovars(null, TovarGroupId);
            ViewBag.TovarsAll =TovarMethods.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult ListTovars([FromBody] List<Param> Params)
        {
            var model = TovarMethods.GetOne();
            return PartialView("ListTovars",model);
        }

        //[HttpPost]
        //public IActionResult MessageHandler([FromBody] RecipeInformation information)
        //{
        //    var t = Request.Body;
        //    string result = "Вийшло!!!";
        //    return Json(result);
        //}
    }
}