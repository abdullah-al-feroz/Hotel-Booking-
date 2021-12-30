using HotelBooking.Model;
using Microsoft.EntityFrameworkCore;

namespace HotelBooking.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<RoomFacility> RoomFacilities { get; set; }
    }
}
