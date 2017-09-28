using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotelManagement.Model.Models
{
    public class BookRoomVehicles
    {
        [Key]
        [Column(Order =1)]
        public int BookRoomID { get;set;}
        [Key]
        [Column(Order = 2)]
        public int VehiclesID { get; set; }
        public int Number { get; set; }

        public virtual BookRoom BookRoom { get; set; }
        public virtual Vehicle Vehicle { get; set; }

    }
}
