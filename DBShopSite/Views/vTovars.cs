using System;
using System.Collections.Generic;
using System.Text;
using DBShopSite.Entities;

namespace DBShopSite.Views
{
    public class ViewFiltersAtribute:FiltersAtribute
    {
        public string Code { get; set; }
    }

    public class ViewFilter : Filter
    {
        public string KindCode { get; set; }
    }

    public class ViewTovar : Tovar
    {
        public int? Rank { get; set; }
    }

}
