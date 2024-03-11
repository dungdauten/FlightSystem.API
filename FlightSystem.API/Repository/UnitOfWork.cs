using FlightSystem.API.IRepository;
using FlightSystem.API.Models;
using FlightSystem.API.Models.Data;
using FlightSystem.API.Models.DTO;
using System.Diagnostics.Metrics;

namespace FlightSystem.API.Repository
{
    public class UnitOfWork:IUnitOfWork
    {

            private readonly ContextCS _context;
            private IGenericRepository<FlightBooking> _flightbookings;
            private IGenericRepository<PlaneInfo> _planeinfos;

            public UnitOfWork(ContextCS context)
            {
                _context = context;
            }
            public IGenericRepository<FlightBooking> FlightBookings => _flightbookings ??= new GenericRepository<FlightBooking>(_context);
            public IGenericRepository<PlaneInfo> PlaneInfos => _planeinfos ??= new GenericRepository<PlaneInfo>(_context);

            public void Dispose()
            {
                _context.Dispose();
                GC.SuppressFinalize(this);
            }

            public async Task Save()
            {
                await _context.SaveChangesAsync();
            }
    }
}
