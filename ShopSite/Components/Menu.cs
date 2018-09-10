using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLShopSite;
using Microsoft.AspNetCore.Mvc;
using DBShopSite.Entities;

namespace ShopSite.Components
{
    public class cMenu: ViewComponent
    {
        List<Menu> _Menu;
        public cMenu()
        {
            _Menu = MenuMethod.GetMenuItems(1);
        }
        public IViewComponentResult Invoke(int maxPrice)
        {
            return View("~/Views/Shared/Menu.cshtml",_Menu);
        }

    }
}
