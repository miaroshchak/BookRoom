using BookRoom.Data;

namespace BookRoom.Services.Interface
{
    public interface IRoomService
    {
        public List<Room> GetRooms();

        public Room GetRoom(int id);
    }
}
