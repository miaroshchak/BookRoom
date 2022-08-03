using BookRoom.Data;

namespace BookRoom.Services.Interface
{
    public interface IBookService
    {
        public List<RoomBook> GetRoomBooksInfo(DateTime date, int roomId);
    }
}
