using MotelManagement.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotelManagement.Model.Models
{
    [Table("Members")]
   public class Member: Auditable
    {
        [Key]
        public int ID { get; set; }
        [Column(TypeName ="varchar")]
        [MaxLength(20)]
        public string Username { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(100)]
        public string Password { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required]
        public string DisplayName { get; set; }
        [Required]
        public bool Status { get; set; }
        [ForeignKey("PermissionID")]
        public virtual Permission Permission { get; set; }
        [Required]
        public int PermissionID { get; set; }
        public virtual Personnel Personnel { get; set; }

    }
}
