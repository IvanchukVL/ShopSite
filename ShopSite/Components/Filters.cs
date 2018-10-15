using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DBShopSite.Entities;
using BLShopSite;

namespace ShopSite.Components
{
    public class cCreateFilterItem : ViewComponent
    {
        public IViewComponentResult Invoke(int? FilterId)
        {
            List<FilterItems> _FilterItems = TovarMethods.GetFilterItems(null, FilterId);
            return View("~/Views/Filter/FilterItems.cshtml", _FilterItems);
        }

    }

}
