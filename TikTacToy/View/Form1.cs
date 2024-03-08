using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;
using TikTacToy.Common.Enums;
using TikTacToy.Presenters;
using TikTacToy.Properties;
using TikTacToy.View.Interface;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TikTacToy
{

    public partial class Form1 : Form, IForm1
    {
        private List<PictureBox> pictureBoxes ;

        public event Action<float> StartGameEvent;
        public event Action<int> ClickEvent;

        public Form1()
        {
            InitializeComponent();
            pictureBoxes = new List<PictureBox> 
            { picture1, picture2, picture3, picture4, picture5, picture6,picture7,picture8,picture9 };
        }

        private void Start(object sender, EventArgs e)
        {
            StartGameEvent?.Invoke(1.1f);
            ClearField();
            EnableField();
            Result.Text = string.Empty;
        }
        private void ClearField()
        {
            for(int i = 0; i < pictureBoxes.Count; i++)
            {
                pictureBoxes[i].BackgroundImage = null;
            }
        }

        private void ClickButton(object sender, EventArgs e)
        {
            var picture = (PictureBox)sender;
            picture.BackgroundImage = Resources.Zero;

           
            ClickEvent?.Invoke(int.Parse(picture.Tag.ToString()));


        }
        public void DrowStep(int index)
        {
            pictureBoxes[index].BackgroundImage = Resources.Cross;
           
        }

        public void ViewReslt(User user)
        {
            Result.Text = user == User.Player 
                ? "Player Win" 
                : user == User.Pc
                    ? "PC Win"
                    : "Drow";
           
            EnableField(false);
                 }
        private void EnableField(bool enable = true)
        {
            for (int i = 0; i < pictureBoxes.Count; i++)
            {
                pictureBoxes[i].Enabled = enable;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void OpenSettings(object sender, EventArgs e)
        {
            View.Interface.Settings settings = new View.Interface.Settings();
            SettingsPresenter presenter = new SettingsPresenter(settings);
            settings.ShowDialog();
        }
    }
}
