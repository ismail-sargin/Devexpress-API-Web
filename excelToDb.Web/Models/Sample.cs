using System;

namespace excelToDb.Web.Models
{

    public class Sample
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public DateTime Date { get; set; }
        public int TotalPax { get; set; }
        public int ReservationNumber { get; set; }

    }
}
