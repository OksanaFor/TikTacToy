

using DTO;
using System;
using System.Collections.Generic;

namespace TikTacToy.View.Interface
{
    public interface IRoomSelectionForm: IBaseView
    {
        event Action LoadNew;
        void ShowRooms (List<RoomDto> rooms);
    }
}
