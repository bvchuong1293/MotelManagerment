using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotelManagement.Model.Models
{
    [Table("BookRoomServices")]
    public class BookRoomService
    {
        [Key]
        [Column(Order =1)]
        public int ServiceID { get; set; }
        [Key]
        [Column(Order = 2)]
        public int BookRoomID { get; set; }
        public int Number { get; set; }

        [ForeignKey("ServiceID")]
        public virtual Service Service { get; set; }
        [ForeignKey("BookRoomID")]
        public virtual BookRoom BookRoom { get; set; }
    }
}
