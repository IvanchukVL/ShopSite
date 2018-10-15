using System;
using DBShopSite.Context;
using DBShopSite.Entities;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BLShopSite
{
    public class MenuMethods
    {
        public static List<vMenu> GetMenuItems(int? UserId, int? ParentId)
        {
            using (DataContext db = new DataContext())
            {
                IQueryable<vMenu> QMenuItems = (from m in db.Menu
                             join rm in db.RolesMenu on m.Id equals rm.MenuId
                             join ur in db.UsersRoles on rm.RoleId equals ur.RoleId
                             where ur.UserId==UserId && m.ParentId== ParentId && m.Status==1
                             select new vMenu {
                                 Id =m.Id,
                                 MenusRoles =m.MenusRoles,
                                 Name =m.Name,
                                 ParentId =m.ParentId,
                                 Status =m.Status,
                                 Url =m.Url,
                                 Code =m.Code,
                                 Command =m.Command,
                                 IsSubMenu = (from mi in db.Menu
                                              where mi.ParentId == m.Id
                                              select 1).Any()
                             }
                             );

                return QMenuItems.ToList();
             }
        }
    }
    public class vMenu:Menu
    {
        public bool IsSubMenu { get; set; }
    }

}
