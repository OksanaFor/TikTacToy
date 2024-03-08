
using TikTacToy.Model;
using TikTacToy.View.Interface;

namespace TikTacToy.Presenters
{
    internal class SettingsPresenter
    {
        private readonly ISettings _view;
        public SettingsPresenter(ISettings view) {
            _view = view;
            _view.OnChoiseLevel += SetSettings;
            _view.Initialize(GameSettings.Instance.Easy);
        }
        private void SetSettings(bool level) { 

            GameSettings.Instance.Easy = level;

        }
    }
}
