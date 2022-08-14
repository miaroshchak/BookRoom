using BookRoom.Data;

namespace BookRoom.Services.Interface
{
    public interface IRoomService
    {
        List<Room> GetRooms();

        Room GetRoom(int id);
    }
}
