using HotelBooking.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelBooking.GenericRepo
{
    public class Repository<T> : IRepo<T> where T : class
    {
        private readonly DataContext _context;
        private readonly DbSet<T> entities;

        public Repository(DataContext context)
        {
            _context = context;
            entities = _context.Set<T>();
        }
        public async Task<IEnumerable<T>> GetAll()
        {
            return await entities.ToListAsync();
        }

        public T GetbyId(int Id)
        {
            return entities.Find(Id);
        }
    }
}
