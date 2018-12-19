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


        public static List<Tovar> GetTovars(int? TovarGroupId, int? NumPage, out int? CountPages)
        {
            using (DataContext db = new DataContext())
            {
                TovarGroup Group = GetTovarGroupInfo(TovarGroupId);
                IQueryable<Tovar> Tovars = db.Tovars
                                                .Where(x => x.GroupId == TovarGroupId || TovarGroupId == null)
                                                .Select(x => new Tovar
                                                {
                                                    Id = x.Id,
                                                    Name = x.Name,
                                                    Status = x.Status,
                                                    GroupId = x.GroupId
                                                });

                CountPages = (int)((double)(Tovars.Count() / (Group.NumberRows* Group.NumberColumns)) + 1);
                var t = Group.NumberColumns * Group.NumberRows * (int)(NumPage - 1);
                return Tovars
                        .Skip(Group.NumberColumns* Group.NumberRows* (int)(NumPage-1))
                        .Take(Group.NumberRows * Group.NumberColumns)
                        .ToList();
            }
        }

        public static List<ViewTovar> GetTovarsWithFiler(List<FilterParam> Params, int? TovarGroupId, int? NumPage, out int? CountPages)
        {
            List<FilterParamExt> ParamsExt = Params.Select(x=>new FilterParamExt(x)).ToList();
            int FiltersCount = ParamsExt.GroupBy(x => x.FilterId).Count();

            if (FiltersCount == 0)
                return GetTovars(TovarGroupId, NumPage,out CountPages).RankTovars(TovarGroupId);

            using (DataContext db = new DataContext())
            {
                TovarGroup Group = GetTovarGroupInfo(TovarGroupId);
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
                CountPages = (int)((double)(Tovars.Count() / (Group.NumberRows * Group.NumberColumns)) + 1);
                return Tovars
                        .Skip(Group.NumberColumns * Group.NumberRows * (int)(NumPage - 1))
                        .Take(Group.NumberRows * Group.NumberColumns)
                        .ToList().RankTovars(TovarGroupId);
            }
        }

        public static TovarGroup GetTovarGroupInfo(int? TovarGroupId)
        {
            using (DataContext db = new DataContext())
            {

                IQueryable<TovarGroup> TovarGroups = db.TovarGroups.Where(x => x.Id == TovarGroupId)
                                                         .Select(x=>x);
                return TovarGroups.First();
            }
        }


        public static List<ViewTovar> RankTovars(this List<Tovar> Tovars, int? TovarGroupId)
        {
            int i = 0;
            TovarGroup Group = GetTovarGroupInfo(TovarGroupId);
            List<ViewTovar> list = Tovars
                            .Select((x, index) => new ViewTovar
                            {
                                Id = x.Id,
                                Name = x.Name,
                                Status = x.Status,
                                GroupId = x.GroupId,
                                Rank = index % Group.NumberColumns == 0 ? ++i : i
                            }).ToList();

            return list.ToList();
        }


    }
}
