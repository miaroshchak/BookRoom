using BookRoom.Model;
using BookRoom.Infrastructure.Extensions;
using BookRoom.Services.Interface;

namespace BookRoom.Services
{
    public class BookService : IBookService
    {
        public List<RoomBooks> GetRoomBooksInfo(DateTime date, int roomId)
        {
            var list = new List<RoomBooks>();
            
            list.Add(new RoomBooks
            {
                StartTime = date.SetTime(10, 00),
                EndTime = date.SetTime(11,00),
                Subject = "First metting",
                CreatedBy = "Myroslav Yaroshchak"
            });

            list.Add(new RoomBooks
            {
                StartTime = date.SetTime(13, 00),
                EndTime = date.SetTime(13, 30),
                Subject = "Second metting",
                CreatedBy = "Myroslav Yaroshchak"
            });

            list.Add(new RoomBooks
            {
                StartTime = date.SetTime(15, 00),
                EndTime = date.SetTime(17, 00),
                Subject = "Third metting",
                CreatedBy = "Myroslav Yaroshchak"
            });

            return list.OrderBy(x => x.StartTime).ToList();
        }
    }
}
