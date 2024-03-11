using AutoMapper;
using FlightSystem.API.Models.Data;
using FlightSystem.API.Models.DTO;
using System.Diagnostics.Metrics;

namespace FlightSystem.API.Configurations
{
    public class MapperInitilizer : Profile
    {
        public MapperInitilizer() 
        {
            CreateMap<FlightBooking, FlightBookingDTO>().ReverseMap();
            CreateMap<FlightBooking, CreateFlightBookingDTO>().ReverseMap();
            CreateMap<FlightBooking, UpdateFlightBookingDTO>().ReverseMap();
            CreateMap<PlaneInfo, PlaneInfoDTO>().ReverseMap();
            CreateMap<PlaneInfo, CreatePlaneInfoDTO>().ReverseMap();
            CreateMap<PlaneInfo, UpdatePlaneInfoDTO>().ReverseMap();
            /*CreateMap<ApiUser, UserDTO>().ReverseMap();*/
        }
    }
}
