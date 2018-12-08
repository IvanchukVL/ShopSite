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

        public static List<Tovar> GetTovarsWithFiler(List<FilterParam> Params)
        {
            List<FilterParamExt> ParamsExt = Params.Select(x=>new FilterParamExt(x)).ToList();
            ParamsExt.RemoveAll(x => x.KindCode == "FilterCheckList" && x.Value == "0");

            using (DataContext db = new DataContext())
            {
                IQueryable<Tovar> Tovars = (from t in db.Tovars
                                            join tv in db.TovarValues on t.Id equals tv.TovarId
                                            where ParamsExt.Exists(x=>x.FilterId==tv.FilterId && x.Value==tv.Amount)
                                            select t
                                           );
                return Tovars.ToList();
            }
        }

    }
}
