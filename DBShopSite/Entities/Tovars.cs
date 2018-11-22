using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBShopSite.Entities
{
    public class Tovar
    {
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        [Required]
        public int GroupId { get; set; }
        [Required]
        public int Status { get; set; }
    }

    public class TovarGroup
    {
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string NameGroup { get; set; }
        public int FilterId { get; set; }
        [Required]
        public int Status { get; set; }
   }

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
        public string TypeFilter { get; set; }
        [Required]
        public int Status { get; set; }
        [ForeignKey("FilterId")]
        public List<FilterItems> FilterItems { get; set; }

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

    public class TovarGroupFilter
    {
        public int Id { get; set; }
        [Required]
        public int TovarGroupId { get; set; }
        [Required]
        public int FilterId { get; set; }
        [Required]
        public int Status { get; set; }
    }


}
