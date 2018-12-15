using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DBShopSite.Context;
using DBShopSite.Entities;
using DBShopSite.Views;


namespace BLShopSite
{
    public static class TovarMethods
    {


        public static List<ViewTovar> GetTovars(int? GroupId)
        {
            using (DataContext db = new DataContext())
            {
                IQueryable<Tovar> Tovars = db.Tovars
                                                .Where(x => x.GroupId == GroupId || GroupId == null)
                                                .OrderBy(x=>x)
                                                .Select(x => new Tovar
                                                {
                                                    Id = x.Id,
                                                    Name = x.Name,
                                                    Status = x.Status,
                                                    GroupId = x.GroupId
                                                });

                return Tovars.ToList().RankTovars();
            }
        }

        public static List<ViewTovar> GetTovarsWithFiler(List<FilterParam> Params, int? TovarGroupId)
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
                         .Select(x => new Tovar
                                                { Id = x.Key.Id,
                                                  Name = x.Key.Name,
                                                  Status = x.Key.Status,
                                                  GroupId = x.Key.GroupId
                                                })     
                         ;

                return Tovars.ToList().RankTovars();
            }
        }

        public static TovarGroup GetGroupInfo(int? GroupId)
        {
            using (DataContext db = new DataContext())
            {

                IQueryable<TovarGroup> TovarGroups = db.TovarGroups.Where(x => x.Id == GroupId)
                                                         .Select(x=>x);
                return TovarGroups.First();
            }
        }


        public static List<ViewTovar> RankTovars(this List<Tovar> Tovars)
        {
            int i = 0;
            List<ViewTovar> list = Tovars
                            .Select((x, index) => new ViewTovar
                            {
                                Id = x.Id,
                                Name = x.Name,
                                Status = x.Status,
                                GroupId = x.GroupId,
                                Rank = index % 3 == 0 ? ++i : i
                            }).ToList();

            return list.ToList();
        }


    }
}
