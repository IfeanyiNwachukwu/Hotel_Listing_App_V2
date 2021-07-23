using HotelListingAppVersion2.Data;
using HotelListingAppVersion2.IRespository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListingAppVersion2.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
        private IGenericRepository<Country> _countries { get; }
        private IGenericRepository<Hotel> _hotels { get; }
        public UnitOfWork(DatabaseContext context)
        {
            _context = context;

        }
        public IGenericRepository<Country> Countries => _countries?? new GenericRepository<Country>(_context);

        public IGenericRepository<Hotel> Hotels => _hotels?? new GenericRepository<Hotel>(_context);

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
