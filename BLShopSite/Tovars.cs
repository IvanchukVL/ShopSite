using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DBShopSite.Context;
using DBShopSite.Entities;


namespace BLShopSite
{
    public class TovarMethods
    {
        public static List<Filter> GetFiltersForTovars(int? UserId, int? TovarGroupId)
        {
            using (DataContext db = new DataContext())
            {
                IQueryable<Filter> QFilterItems = (from f in db.Filters
                                                join tf in db.TovarGroupFilters on f.Id equals tf.FilterId
                                                where tf.TovarGroupId == TovarGroupId
                                                 select f);

                return QFilterItems.ToList();
            }
        }

        public static List<FilterItems> GetFilterItems(int? UserId, int? FilterId)
        {
            using (DataContext db = new DataContext())
            {
                IQueryable<FilterItems> QFilterItems = (from fi in db.FilterItems
                                                   where fi.FilterId == FilterId
                                                   select fi);

                return QFilterItems.ToList();
            }
        }

    }
}
