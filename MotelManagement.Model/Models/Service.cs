using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotelManagement.Model.Models
{
    [Table("Services")]
    public class Service
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        public double UnitPrice { get; set; }
        public virtual IEnumerable<ImportGoods> ImportGoods { get; set; }
        public virtual IEnumerable<BookRoomService> BookRoomService { get; set; }
    }
}
