using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBShopSite.Entities
{
    public class Roles
    {
        public int Id { get; set; }
        public string RoleCode { get; set; }
        public string RoleName { get; set; }
        public int? Status { get; set; }
        [ForeignKey("RoleId")]
        public List<RolesMenu> RolesMenu { get; set; }

    }
    public class RolesMenu
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int MenuId { get; set; }
        public int Status { get; set; }
    }

}
