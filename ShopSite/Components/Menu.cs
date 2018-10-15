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
        List<vMenu> _Menu;
        public cMenu()
        {
            _Menu = MenuMethods.GetMenuItems(1,0);
        }
        public IViewComponentResult Invoke(int maxPrice)
        {
            return View("~/Views/Menu/Menu.cshtml",_Menu);
        }

    }

    public class cMenuItems : ViewComponent
    {
        List<vMenu> _MenuItems;
        public cMenuItems()
        {
        }
        public IViewComponentResult Invoke(int? ParentId)
        {
            _MenuItems = MenuMethods.GetMenuItems(1, ParentId);
            return View("~/Views/Menu/MenuItems.cshtml", _MenuItems);
        }

    }


}
