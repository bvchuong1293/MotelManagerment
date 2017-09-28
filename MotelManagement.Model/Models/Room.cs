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
    [Table("Rooms")]
    public class Room
    {
        [Key]
        [MaxLength(20)]
        public string ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public int Status { get; set; }
        [MaxLength(20)]
        public string RoomTypeID { get; set; }
        [ForeignKey("RoomTypeID")]
        public virtual RoomType RoomType { get; set; }
        public virtual IEnumerable<BookRoom> BookRoom { get; set; }
    }
}
