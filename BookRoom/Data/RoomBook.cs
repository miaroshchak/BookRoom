namespace BookRoom.Data
{
    public class RoomBook
    {
        public int Id { get; set; }

        public int RoomId { get; set; }

        public string Subject { get; set; } = string.Empty;

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string CreatedBy { get; set; }


        public Room Room { get; set; }
    }
}
