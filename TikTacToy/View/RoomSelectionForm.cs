
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TikTacToy.View.Interface
{
    public partial class RoomSelectionForm : Form, IRoomSelectionForm
    {
        public RoomSelectionForm()
        {
            InitializeComponent();
        }

        public event Action LoadNew;

        public void ShowNotification(string message)
        {
            throw new NotImplementedException();
        }

        public void ShowRooms(List<RoomDto> rooms)
        {
            roomList.Items.AddRange(rooms.Select(s => s.Name).ToArray());

        }

        private void RoomSelectionForm_Shown(object sender, EventArgs e)
        {
            LoadNew?.Invoke();
        }
    }
}
