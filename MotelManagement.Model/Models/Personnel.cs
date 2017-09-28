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
    [Table("Personnels")]
    public class Personnel
    {
        [Key]
        [ForeignKey("Member")]
        public int ID { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        public DateTime? BirthDay { get; set; }

        public bool? Sex { get; set; }

        [MaxLength(100)]
        public string HomeTown { get; set; }

        public virtual Member Member { get; set; }
    }
}
