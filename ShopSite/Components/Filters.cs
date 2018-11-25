using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DBShopSite.Entities;
using BLShopSite;

namespace ShopSite.Components
{
    public class cFilterItem : ViewComponent
    {
        public IViewComponentResult Invoke(int? FilterId, string FilterName, string FilterType)
        {
            List<FilterItems> _FilterItems = TovarMethods.GetFilterItems(null, FilterId);
            ViewBag.FilterName = FilterName;
            ViewBag.FilterId = FilterId;
            ViewBag.FilterAtributes = TovarMethods.GetFilterAtributes(null,FilterId);
            return View($"~/Views/Tovars/Filter/{FilterType}.cshtml", _FilterItems);
        }
    }

}
