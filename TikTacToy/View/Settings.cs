using System;
using System.Windows.Forms;
using TikTacToy.Model;

namespace TikTacToy.View.Interface
{
    public partial class Settings : Form, ISettings
    {
        public Settings()
        {
            InitializeComponent();
            
        }

        public event Action<bool> OnChoiseLevel;

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Applied(object sender, EventArgs e)
        {
            OnChoiseLevel?.Invoke(easy.Checked);
            Close();
        }
        public void Initialize(bool level)
        {
            easy.Checked = level;
            
        }

    }
}
