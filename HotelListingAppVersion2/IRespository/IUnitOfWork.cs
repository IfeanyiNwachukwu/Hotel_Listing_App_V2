using HotelListingAppVersion2.Data;
using System;
using System.Threading.Tasks;

namespace HotelListingAppVersion2.IRespository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Country> Countries { get; }
        IGenericRepository<Hotel> Hotels { get; }

        Task Save();
    }
}
