using HotelBooking.GenericRepo;
using HotelBooking.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotelBooking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IRepo<Room> _roomRepo;
        private readonly IRepo<RoomType> _roomTypeRepo;
        private readonly IRepo<RoomFacility> _roomFacility;

        public HomeController(IRepo<Room> roomRepo, IRepo<RoomType> roomTypeRepo, IRepo<RoomFacility> roomFacility)
        {
            _roomRepo = roomRepo;
            _roomTypeRepo = roomTypeRepo;
            _roomFacility = roomFacility;
        }

        [HttpGet("Room")]
        public async Task <IEnumerable<Room>> GetRoom()
        {
            return await _roomRepo.GetAll();
        }
        [HttpGet("RoomTypes")]
        public async Task <IEnumerable<RoomType>> GetRoomType()
        {
            return await _roomTypeRepo.GetAll();
        }
        [HttpGet("RoomFacily")]
        public async Task<IEnumerable<RoomFacility>>GetRoomFacilities()
        {
            return await _roomFacility.GetAll();
        }
    }
}
