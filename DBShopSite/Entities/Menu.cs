using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBShopSite.Entities
{
    public class Menu
    {
        public int Id { get; set; }
        [Required]
        public string Code { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Command { get; set; }
        public int Status { get; set; }

        [ForeignKey("MenuId")]
        public List<MenuRole> MenuRoles { get; set; }
    }

    public class MenuRole
    {
        public int Id { get; set; }
        public int MenuId { get; set; }
        public int RoleId { get; set; }
        public int Status { get; set; }
    }
}
