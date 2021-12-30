using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotelBooking.GenericRepo
{
    public interface IRepo<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetbyId(int id);

    }
}
