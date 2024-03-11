using FlightSystem.API.Models;
using FlightSystem.API.Models.Data;
using FlightSystem.API.Models.DTO;
using System.Diagnostics.Metrics;

namespace FlightSystem.API.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<FlightBooking> FlightBookings { get; }
        IGenericRepository<PlaneInfo> PlaneInfos { get; }
        Task Save();
    }
}
