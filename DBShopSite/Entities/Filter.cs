using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBShopSite.Entities
{
    public class Filter
    {
        public int Id { get; set; }
        [Required]
        [StringLength(70)]
        public string Code { get; set; }
        [StringLength(150)]
        public string Name { get; set; }
        [Required]
        [StringLength(150)]
        public int? Kind { get; set; }
        [Required]
        public int Status { get; set; }
        [ForeignKey("FilterId")]
        public List<FilterItems> FilterItems { get; set; }

    }

    public class FilterKind
    {
        public int Id { get; set; }
        [Required]
        [StringLength(70)]
        public string Code { get; set; }
        [StringLength(150)]
        public string Name { get; set; }
    }

    /// <summary>
    /// Атрибут для фільтра
    /// DataType - 1- числове значення (крапка як розділовий знак між цілою і дробовою частиною);
    ///            2- текстове значення;
    ///            3- дата/час;
    /// </summary>
    public class Atribute
    {
        public int Id { get; set; }
        [Required]
        [StringLength(70)]
        public string Code { get; set; }
        [StringLength(150)]
        public string Name { get; set; }
        public int DataType { get; set; }
    }

    /// <summary>
    /// Звязка між фільтром і його атрибутами
    /// </summary>
    public class FiltersAtribute
    {
        public int Id { get; set; }
        [Required]
        public int FilterId { get; set; }
        [Required]
        public int AtributeId { get; set; }
        public string Value { get; set; }
        [StringLength(150)]
        public int Status { get; set; }
    }


    public class FilterItems
    {
        public int Id { get; set; }
        public int FilterId { get; set; }
        public string Code { get; set; }
        [StringLength(150)]
        public string Name { get; set; }
        [Required]
        public int Status { get; set; }
    }

    public class FilterParam
    {
        public string Id { get; set; }
        public string Value { get; set; }
    }

    public class FilterParamExt : FilterParam
    {
        public FilterParamExt()
        {
        }

        public FilterParamExt(FilterParam Param)
        {
            string[] Pr = Param.Id.Split('_');
            Id = Param.Id;
            Value = Param.Value;
            KindCode = Pr[1];
            FilterId = Convert.ToInt32(Pr[2]);
            if (Pr.Length >= 4)
                FilterItemId = Convert.ToInt32(Pr[3]); ;

        }
        public string KindCode { get; set; }
        public int? FilterId { get; set; }
        public int? FilterItemId { get; set; }
    }

}
