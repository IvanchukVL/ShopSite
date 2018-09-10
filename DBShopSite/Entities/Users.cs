using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBShopSite.Entities
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Login { get; set; }
        [Required]
        [StringLength(70)]
        public string Name { get; set; }
        [StringLength(70)]
        public string eMail { get; set; }
        [StringLength(250)]
        public string Comment { get; set; }
        [Required]
        public int? Status { get; set; }
        [ForeignKey("UserId")]
        public List<UsersRoles> UsersRoles { get; set; }
    }

    public class UserHistory
    {
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public int Status { get; set; }
    }
    public class UsersRoles
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public int Status { get; set; }
    }



}
