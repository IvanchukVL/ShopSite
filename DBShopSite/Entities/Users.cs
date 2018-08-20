using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

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
        [Required]
        public int Status { get; set; }
    }

    public class UserHistory
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Status { get; set; }

    }

}
