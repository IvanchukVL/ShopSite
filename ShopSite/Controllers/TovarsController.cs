using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DBShopSite.Entities;
using DBShopSite.Views;
using BLShopSite;

namespace ShopSite.Controllers
{

    public class TovarsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ReviewTovars(int? Id, int? TovarGroupId)
        {
            //Діні потрібні для формування фільтрів----------------------------------------------
            ViewBag.Id = Id;
            ViewBag.TovarGroupId = TovarGroupId;
            ViewBag.ListFilter = FilterMethods.GetFiltersForTovars(null, TovarGroupId);
            List<FilterParam> Params = new List<FilterParam>();
            //-----------------------------------------------------------------------------------

            Params.Add(new FilterParam() { Id = "TovarGroupId", Value = TovarGroupId.ToString() });
            Params.Add(new FilterParam() { Id = "NumPage", Value = "1" });
            ViewBag.TovarsAll = GetTovars(Params);
            return View();
        }

        [HttpPost]
        public IActionResult ListTovars([FromBody] List<FilterParam> Params)
        {
            var model = GetTovars(Params);
            return PartialView("ListTovars",model);
        }

        public List<ViewTovar> GetTovars(List<FilterParam> Params)
        {
            int? TovarGroupId = null;
            int? CountPages, NumPage=1;
            FilterParam ItemTovarGroupId = Params.Find(x => x.Id == "TovarGroupId");
            if (ItemTovarGroupId != null)
            {
                TovarGroupId = Convert.ToInt32(ItemTovarGroupId.Value);
                Params.Remove(ItemTovarGroupId);
            }
            FilterParam ItemNumPage = Params.Find(x => x.Id == "NumPage");
            if (ItemNumPage != null)
            {
                NumPage = Convert.ToInt32(ItemNumPage.Value);
                Params.Remove(ItemNumPage);
                ViewBag.NumPage = NumPage;
            }

            ViewBag.NumberColumns = TovarMethods.GetTovarGroupInfo(TovarGroupId).NumberColumns;
            var list = TovarMethods.GetTovarsWithFiler(Params, TovarGroupId, NumPage, out CountPages);
            ViewBag.CountPages = CountPages;
            return list;
        }
    }
}