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
            Form1 form = new Form1();
            Form1Presenter form1Presenter = new Form1Presenter(form);
            Hide();
            form.Show();
        }

        public void ShowNotification(string message)
        {
            MessageBox.Show(message);
        }

        private void ClickOpenGame(object sender, EventArgs e)
        {
            AuthorizationEvent?.Invoke("","");

        }
    }
}
