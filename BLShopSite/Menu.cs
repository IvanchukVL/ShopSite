using System;
using DBShopSite.Context;
using DBShopSite.Entities;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BLShopSite
{
    public class MenuMethod
    {
        public static List<Menu> GetMenuItems(int UserId)
        {
            using (DataContext db = new DataContext())
            {
                IQueryable<Menu> QMenuItems = (from m in db.Menu
                             join rm in db.RolesMenu on m.Id equals rm.MenuId
                             join ur in db.UsersRoles on rm.RoleId equals ur.RoleId
                             where ur.UserId==UserId
                             select m);

                return QMenuItems.ToList();
             }
        }

    }
}
