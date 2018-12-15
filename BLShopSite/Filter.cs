using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DBShopSite.Context;
using DBShopSite.Entities;
using DBShopSite.Views;

namespace BLShopSite
{
    public class FilterMethods
    {

        public static List<ViewFilter> GetFiltersForTovars(int? UserId, int? TovarGroupId)
        {
            using (DataContext db = new DataContext())
            {
                IQueryable<ViewFilter> QFilterItems = (from f in db.Filters
                                                    join tf in db.TovarGroupFilters on f.Id equals tf.FilterId
                                                    join fk in db.FilterKinds on f.Kind equals fk.Id
                                                    where tf.TovarGroupId == TovarGroupId
                                                    select new ViewFilter
                                                    {
                                                        Id = f.Id,
                                                        Name = f.Name,
                                                        Kind = f.Kind,
                                                        Status = f.Status,
                                                        KindCode = fk.Code
                                                    }
                                                   );

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

        public static List<ViewFiltersAtribute> GetFilterAtributes(int? UserId, int? FilterId)
        {
            using (DataContext db = new DataContext())
            {
                IQueryable<ViewFiltersAtribute> QFilterItems = (from fa in db.FiltersAtributes
                                                             join a in db.Atributes on fa.AtributeId equals a.Id
                                                             where fa.FilterId == FilterId
                                                             select new ViewFiltersAtribute
                                                             {
                                                                 Id = fa.Id,
                                                                 AtributeId = fa.AtributeId,
                                                                 FilterId = fa.FilterId,
                                                                 Value = fa.Value,
                                                                 Status = fa.Status,
                                                                 Code = a.Code,
                                                             }
                                                        );

                return QFilterItems.ToList();
            }
        }
    }
}
