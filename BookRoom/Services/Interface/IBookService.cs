using BookRoom.Model;

namespace BookRoom.Services.Interface
{
    public interface IBookService
    {
        public List<RoomBooks> GetRoomBooksInfo(DateTime date, int roomId);
    }
}
