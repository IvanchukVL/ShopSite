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


        public static List<Tovar> GetTovars(int? GroupId)
        {
            using (DataContext db = new DataContext())
            {

                IQueryable<Tovar> Tovars = (from t in db.Tovars
                                            where t.GroupId == GroupId || GroupId == null
                                            select t
                                           );
                return Tovars.ToList();
            }
        }

        public static List<Tovar> GetTovarsWithFiler(List<FilterParam> Params, int? TovarGroupId)
        {
            List<FilterParamExt> ParamsExt = Params.Select(x=>new FilterParamExt(x)).ToList();
            int FiltersCount = ParamsExt.GroupBy(x => x.FilterId).Count();

            if (FiltersCount == 0)
                return GetTovars(TovarGroupId);

            using (DataContext db = new DataContext())
            {
                IQueryable<Tovar> Tovars = db.Tovars.Join(db.TovarValues,
                                t => t.Id,
                                v => v.TovarId,
                                (t, v) => new { t, v })
                         .Join(db.TovarAtributes,
                                tv => tv.v.AtributeId,
                                tp => tp.Id,
                                (tv, tp) => new { tv, tp })
                         .Where(x=> ((x.tv.v.FilterId ?? -1) != -1))
                         .Where(x=>ParamsExt.Exists(y=>y.FilterId == x.tv.v.FilterId
                                                        &&
                                                        (
                                                            (x.tp.Kind == 2 && y.FilterItemId == x.tv.v.Flag)
                                                            ||
                                                            (x.tp.Kind == 3 && Convert.ToDecimal(y.Value) <= x.tv.v.Amount && Convert.ToDecimal(y.Value2) >= x.tv.v.Amount)
                                                        )
                                                    )
                               )
                         .GroupBy(x=> new { x.tv.t.Id, x.tv.t.Name, x.tv.t.Status, x.tv.t.GroupId })
                         .Where(x=>x.Count()>= FiltersCount)
                         .Select(x => new Tovar { Id = x.Key.Id,
                                                  Name = x.Key.Name,
                                                  Status = x.Key.Status,
                                                  GroupId = x.Key.GroupId })     
                         ;

                //IQueryable<Tovar> Tovars =
                //                        (from tb in 
                //                            (from t in db.Tovars
                //                                join tv in db.TovarValues on t.Id equals tv.TovarId
                //                                join ta in db.TovarAtributes on tv.AtributeId equals ta.Id
                //                                where ParamsExt.Exists(x =>
                //                                        x.FilterId == tv.FilterId
                //                                      &&
                //                                       (
                //                                        (ta.Kind == 2 && x.FilterItemId == tv.Flag)
                //                                        ||
                //                                        (ta.Kind == 3 && Convert.ToDecimal(x.Value) <= tv.Amount && Convert.ToDecimal(x.Value2) >= tv.Amount)
                //                                       )
                //                                      &&
                //                                        ((tv.FilterId ?? -1) != -1)
                //                                      )
                //                                select t
                //                               )
                //                         group tb by new { tb.Id, tb.Name, tb.Status, tb.GroupId }
                //                         into g
                //                         where g.Count() >= FiltersCount
                //                         orderby g.Key.Id
                //                         select new Tovar
                //                         {
                //                             Id = g.Key.Id,
                //                             Name = g.Key.Name,
                //                             Status = g.Key.Status,
                //                             GroupId = g.Key.GroupId
                //                         }
                //                       );
                return Tovars.ToList();
            }
        }

    }
}
