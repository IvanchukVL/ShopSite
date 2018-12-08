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
        public IViewComponentResult Invoke(int? FilterId, string FilterName, string FilterKindCode)
        {
            List<FilterItems> _FilterItems = FilterMethods.GetFilterItems(null, FilterId);
            ViewBag.FilterName = FilterName;
            ViewBag.FilterKindCode = FilterKindCode;
            ViewBag.FilterId = FilterId;
            ViewBag.FilterAtributes = FilterMethods.GetFilterAtributes(null,FilterId);
            return View($"~/Views/Tovars/Filter/{FilterKindCode}.cshtml", _FilterItems);
        }
    }

}
