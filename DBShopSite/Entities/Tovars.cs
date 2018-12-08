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

    /// <summary>
    /// Довідник атрибутів (параметрів) товару
    /// Kind - 1-Code, 2-Flag, 3-amount, 4 - Info  
    /// </summary>
    public class TovarAtribute
    {
        public int Id { get; set; }
        [Required]
        public string Code { get; set; }
        public string Name { get; set; }
        public int Kind { get; set; }
        public int Status { get; set; }
    }

    /// <summary>
    /// Значення параметру для товару
    /// </summary>
    public class TovarValue
    {
        public int Id { get; set; }
        [Required]
        public int TovarId { get; set; }
        [Required]
        public int AtributeId { get; set; }
        [StringLength(32)]
        public string Code { get; set; }
        public int? Flag { get; set; }
        public decimal? Amount { get; set; }
        public string Info { get; set; }
        public int? FilterId { get; set; }
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
