using System.ComponentModel.DataAnnotations;

namespace FlightSystem.API.Models.Data
{
    public class PlaneInfo
    {
        public int PlaneID { get; set; }  
        public string APlaneName { get; set; }
        public int APlaneCapity { get; set; }
        public float Price { get; set; }
        public virtual IList<FlightBooking> FlightBookings { get; set; }
    }
}
