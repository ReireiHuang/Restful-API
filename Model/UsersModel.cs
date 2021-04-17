using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestfulProject.Model
{
    [Table("Users")]
    public class Users
    {
        [Required]
        [Key]
        public int UserId { get; set; }
        [StringLength(10)]
        public string UserName { get; set; }
        [StringLength(10)]
        public string Character { get; set; }
    }
}
