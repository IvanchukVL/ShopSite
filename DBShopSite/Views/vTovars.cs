using System;
using System.Collections.Generic;
using System.Text;
using DBShopSite.Entities;

namespace DBShopSite.Views
{
        public class vFiltersAtribute:FiltersAtribute
        {
            public string Code { get; set; }
        }

    public class vFilter : Filter
    {
        public string KindCode { get; set; }
    }

}
