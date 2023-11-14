using System;
using System.Collections.Generic;
using System.Windows.Forms;
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
        }
        private void ClearField()
        {
            for(int i = 0; i < pictureBoxes.Count; i++)
            {
                pictureBoxes[i].Image = null;
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



    }
}
