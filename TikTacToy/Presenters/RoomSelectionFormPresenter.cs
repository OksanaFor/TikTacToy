
using TikTacToy.Model;
using TikTacToy.View.Interface;

namespace TikTacToy.Presenters
{
    public class RoomSelectionFormPresenter
    {
        private readonly IRoomSelectionForm _view;
        private readonly RoomDbServise _roomDbServise = new RoomDbServise();

        public RoomSelectionFormPresenter(IRoomSelectionForm view)
        {
            _view = view;
            view.LoadNew += GetAllRooms;
            view.EnterRoom += GetAllRooms;
        }
        private async void GetAllRooms()
        {
           var rooms = await _roomDbServise.GetAll();
           _view.ShowRooms(rooms);
        }
        

    }
}
