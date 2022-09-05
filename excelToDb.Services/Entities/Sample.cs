using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excelToDb.Data.Entities
{
    
    public class Sample
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public int TotalPax { get; set; }
        public int ReservationNumber { get; set; }
        [NotMapped]
        public bool Selected { get; set; }

    }
}
