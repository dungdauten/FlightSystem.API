using System.ComponentModel.DataAnnotations;

namespace FlightSystem.API.Models.DTO
{
    public class CreatePlaneInfoDTO
    {
        [Key]
        public int PlaneID { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập tên máy bay")]
        [MaxLength(20, ErrorMessage = "Tối đa 20 kí tự")]
        [Display(Name = "Tên máy bay")]
        public string APlaneName { get; set; }

        [Required(ErrorMessage = "Nhập vào số lượng khách có thể chở")]
        [Display(Name = "Số lượng hành khách")]
        public int APlaneCapity { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập giá vé máy bay")]
        public float Price { get; set; }
    }

    public class UpdatePlaneInfoDTO : CreatePlaneInfoDTO
    {
        public IList<CreatePlaneInfoDTO> Planes { get; set; }
    }

    public class PlaneInfoDTO : CreatePlaneInfoDTO
    {
        public int Id { get; set; }
        public IList<FlightBookingDTO> FlightBookings { get; set; }
    }
}
