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
        public int TypeFilter { get; set; }
        [Required]
        public int Status { get; set; }
        [ForeignKey("FilterId")]
        public List<FilterItems> FilterItems { get; set; }

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
