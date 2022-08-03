using BookRoom.Data;

namespace BookRoom.Services.Interface
{
    public interface IRoomBookService
    {
        public List<RoomBook> GetRoomBooks(DateTime date, int roomId);
    }
}
