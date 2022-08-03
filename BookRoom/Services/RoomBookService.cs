using BookRoom.Infrastructure.Extensions;
using BookRoom.Services.Interface;
using BookRoom.Data;

namespace BookRoom.Services
{
    public class RoomBookService : IRoomBookService
    {
        private readonly ApplicationDbContext _dbContext;

        public RoomBookService(ApplicationDbContext dbContext) 
        {
                _dbContext = dbContext;
        }

        public List<RoomBook> GetRoomBooks(DateTime date, int roomId)
        {
            var list = new List<RoomBook>();
            
            list.Add(new RoomBook
            {
                StartTime = date.SetTime(10, 00),
                EndTime = date.SetTime(11,00),
                Subject = "First metting",
                CreatedBy = "Myroslav Yaroshchak"
            });

            list.Add(new RoomBook
            {
                StartTime = date.SetTime(13, 00),
                EndTime = date.SetTime(13, 30),
                Subject = "Second metting",
                CreatedBy = "Myroslav Yaroshchak"
            });

            list.Add(new RoomBook
            {
                StartTime = date.SetTime(15, 00),
                EndTime = date.SetTime(17, 00),
                Subject = "Third metting",
                CreatedBy = "Myroslav Yaroshchak"
            });

            return list.OrderBy(x => x.StartTime).ToList();
        }

        public List<RoomBook> GetRoomBooks(DateTime date, int roomId, int hour)
        {
            throw new NotImplementedException();
        }
    }
}
