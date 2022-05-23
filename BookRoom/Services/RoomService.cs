using BookRoom.Data;
using BookRoom.Services.Interface;

namespace BookRoom.Services
{
    public class RoomService : IRoomService
    {
        private static List<Room> list = new() 
        {
            new Room
            {
                Id = 1,
                Name = "Room 111",
                Floor = "3",
                Description = "some description"
            },
            new Room
            {
                Id = 2,
                Name = "Room 112",
                Floor = "3",
                Description = "some description"
            },
            new Room
            {
                Id = 3,
                Name = "Room 113",
                Floor = "3",
                Description = "some description"
            }
        };

        public Room GetRoom(int id)
        {
            return list.First(x => x.Id == id);
        }

        public List<Room> GetRooms()
        {
            return list;
        }
    }
}
