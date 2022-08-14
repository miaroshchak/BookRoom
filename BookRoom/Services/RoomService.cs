using BookRoom.Data;
using BookRoom.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace BookRoom.Services
{
    public class RoomService : IRoomService
    {
        private readonly ApplicationDbContext _dbContext;

        public RoomService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Room GetRoom(int id)
        {
            return _dbContext.Rooms.Find(id);
        }

        public List<Room> GetRooms()
        {
            return _dbContext.Rooms.ToList();
        }
    }
}
