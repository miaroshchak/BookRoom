using BookRoom.Data;
using BookRoom.Services.Interface;
using Microsoft.AspNetCore.Components;
using System.Globalization;

namespace BookRoom.Components.RoomComponent
{
    public class RoomModel : ComponentBase
    {
        [Parameter]
        public int RoomId { get; set; }

        [Parameter]
        public DateTime Date { get; set; }

        public CultureInfo Culture => new CultureInfo("uk-UA", false);


        public Room CurrentRoom => roomService.GetRoom(RoomId);


        [Inject]
        protected IBookService bookService { get; set; } = default!;

        [Inject]
        protected IRoomService roomService { get; set; } = default!;

    }
}
