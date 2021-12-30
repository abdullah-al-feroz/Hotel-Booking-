using HotelBooking.GenericRepo;
using HotelBooking.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
        public IEnumerable<Room> GetRoom()
        {
            return _roomRepo.GetAll();
        }
        [HttpGet("RoomTypes")]
        public IEnumerable<RoomType> GetRoomType()
        {
            return _roomTypeRepo.GetAll();
        }
        [HttpGet("RoomFacily")]
        public IEnumerable<RoomFacility>GetRoomFacilities()
        {
            return _roomFacility.GetAll();
        }
    }
}
