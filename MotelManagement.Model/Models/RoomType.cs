using MotelManagement.Model.Abstract;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MotelManagement.Model.Models
{
    [Table("TypeRooms")]
    public class RoomType: Auditable
    {
        [Key]
        public string ID { get; set; }

        [MaxLength(50)]
        public string NameRoomType { get; set; }
        public double HourPrice { get; set; }
        public double OverNightPrice { get; set; }
        public double DayPrice { get; set; }
        public double FinePrice { get; set; }
        public virtual IEnumerable<Room> Room { get; set; }
    }
}
