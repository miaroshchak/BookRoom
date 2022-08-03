namespace BookRoom.ModelView
{
    public class RoomBookView
    {
        public int Id { get; set; }

        public int RoomId { get; set; }

        public string Subject { get; set; } = string.Empty;

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string CreatedBy { get; set; }

        public int Persent { get; set; }
    }
}
