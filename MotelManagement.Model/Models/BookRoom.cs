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
    [Table("BookRooms")]
    public class BookRoom: Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        
        public DateTime TimeIn { get; set; }

        public DateTime TimeOut { get; set; }

        public int Fomality { get; set; }

        public double PrePay { get; set; }
        public double Promotion { get; set; }
        public int VehiclesID { get; set; }
        public int ServiceID { get; set; }
        [Required]
        [MaxLength(20)]
        public string RoomID { get; set; }
        public int CustomerID { get; set; }

        [ForeignKey("RoomID")]
        public virtual Room Room { get; set; }
        public virtual IEnumerable<BookRoomService> BookRoomService { get; set; }
        [ForeignKey("CustomerID")]
        public virtual Customer Customer { get; set; }
    }
}
