using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FlightSystem.API.Models.DTO
{
    [Table("TblFlightBook")]
    public class CreateFlightBookingDTO
    {
        [Key]
        public int BookingId { get; set; }
        public string FromCity { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn địa điểm đến")]
        [Display(Name = "Địa điểm đến")]
        [StringLength(40)]  
        public string ToCity { get; set; }

        [Display(Name = "Giờ khởi hành")]
        [DataType(DataType.Time)]
        public string DTime { get; set; }

        [Display(Name = "Ngày khởi hành")]
        [DataType(DataType.Date)]
        public string DDay { get; set; }

        public int PlaneId { get; set; }
        [Display(Name = "Loại vé ngồi")]
        [StringLength(10)]
        public string SeatType { get; set; }

        

    }
    public class UpdateFlightBookingDTO : CreateFlightBookingDTO
    {
        public IList<CreateFlightBookingDTO> Flights { get; set; }
    }
    public class FlightBookingDTO : CreateFlightBookingDTO
    {
        public int Flight_Id { get; set; }
        public PlaneInfoDTO PlaneInfo { get; set; }
    }
}
