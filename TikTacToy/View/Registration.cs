using System;
using System.Windows.Forms;
using TikTacToy.Presenters;
using TikTacToy.View.Interface;

namespace TikTacToy.View
{
    public partial class Registration : Form, IRegistration
    {
        public Registration()
        {
            InitializeComponent();
        }

        public event Action<string, string> RegisterationEvent;
        public event Action<string, string> AuthorizationEvent;


        public void OpenGame()
        {
            RoomSelectionForm form = new RoomSelectionForm();
            RoomSelectionFormPresenter form1Presenter = new RoomSelectionFormPresenter(form);
            Hide();
            form.Show();
        }

        public void ShowNotification(string message)
        {
            MessageBox.Show(message);
        }

        private void ClickOpenGame(object sender, EventArgs e)
        {
            AuthorizationEvent?.Invoke(textBox1.Text, textBox2.Text);

        }
        private void RegistrationOpenGame(object sender, EventArgs e)
        {
            RegisterationEvent?.Invoke(textBox1.Text, textBox2.Text);
        }
    }
}
