using BookRoom.Services.Interface;
using Microsoft.AspNetCore.Components;

namespace BookRoom.Components.RoomsComponent
{
    public class RoomsModel : ComponentBase
    {
        public static string RoomRoute(int roomId) => $"/schedule/room/{roomId}";

        [Inject]
        protected IRoomBookService bookService { get; set; } = default!;

        [Inject]
        protected IRoomService roomService { get; set; } = default!;

        [Inject]
        protected NavigationManager NavigationManager { get; set; } = default!;

        protected void NavigateToScheduleRoom(int roomId)
        {
            NavigationManager.NavigateTo(RoomRoute(roomId));
        }
    }
}
