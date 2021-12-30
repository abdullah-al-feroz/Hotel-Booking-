namespace HotelBooking.Model
{
    public class Room
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int MaxAudlts { get; set; }
        public int MaxChild { get; set; }
        public decimal RoomFare { get; set; }
        public string Description { get; set; }
        public int NoOfBed { get; set; }
        public string RoomPictureUri { get; set; }
        public RoomType TypeOfRoom { get; set; }
        public int RoomTypeId { get; set; }
    }
}
