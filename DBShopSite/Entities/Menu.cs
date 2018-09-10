using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBShopSite.Entities
{
    public class Menu
    {
        [Key]
        public int Id { get; set; }
        public int ParentId { get; set; }
        [Required][StringLength(32)]
        public string Code { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        public string Url { get; set; }
        [StringLength(32)]
        public string Command { get; set; }
        public int Status { get; set; }

        [ForeignKey("MenuId")]
        public List<RolesMenu> MenusRoles { get; set; }
    }

}
