using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DBShopSite.Context;
using DBShopSite.Entities;
using DBShopSite.Views;


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

        public static List<vFiltersAtribute> GetFilterAtributes(int? UserId, int? FilterId)
        {
            using (DataContext db = new DataContext())
            {
                IQueryable<vFiltersAtribute> QFilterItems = (from fa in db.FiltersAtributes
                                                             join a in db.Atributes on fa.AtributeId equals a.Id
                                                             where fa.FilterId == FilterId
                                                             select new vFiltersAtribute
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


        public static List<Tovar> GetAll()
        {
            List<Tovar> cars = new List<Tovar>{
                new Tovar{Id = 1, Name="Audi1", Status=1},
                new Tovar{Id = 2, Name="Audi2", Status=1},
                new Tovar{Id = 3, Name="Audi3", Status=1}
                };
            return cars;
        }

        public static List<Tovar> GetOne()
        {
            List<Tovar> cars = new List<Tovar>{
                new Tovar{Id = 1, Name="Audi1", Status=1},
                };
            return cars;
        }

    }


}
