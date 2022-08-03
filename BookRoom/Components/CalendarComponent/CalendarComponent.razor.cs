using BookRoom.Infrastructure.Extensions;
using BookRoom.Services.Interface;
using Microsoft.AspNetCore.Components;
using System.Globalization;

namespace BookRoom.Components.CalendarComponent
{
    public class CalendarModel : ComponentBase
    {
        public IEnumerable<DateTime> DaysOfWeek => DateTime.UtcNow.GetDaysOfWeek();
        public CultureInfo Culture => new CultureInfo("uk-UA", false);


        public static string RoomRoute(int roomId, DateTime date) => $"/schedule/room/{roomId}/{date.ToString("yyyy-MM-dd")}";


        [Inject]
        protected IRoomBookService bookService { get; set; } = default!;

        [Inject]
        protected IRoomService roomService { get; set; } = default!;

        [Inject]
        protected NavigationManager NavigationManager { get; set; } = default!;

        protected void NavigateToToRoom(int roomId, DateTime date)
        {
            NavigationManager.NavigateTo(RoomRoute(roomId, date));
        }
    }
}
