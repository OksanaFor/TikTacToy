
using TikTacToy.Common.Enums;
using TikTacToy.Model;
using TikTacToy.View.Interface;

namespace TikTacToy.Presenters
{
    public class Form1Presenter 

    {
        private readonly IForm1 _view;
        private readonly MainLogic _model = new MainLogic();

        public Form1Presenter(IForm1 view)
        {
            _view = view;
            _view.StartGameEvent += Start;
            _view.ClickEvent += Click;
           


        }
        private void Start(float temp)
        {
            _model.ClearField();

        }
        private void Click(int index)
        {
            _model.PlayerStep(index);
            if (_model.IsWin(CellCondition.Zero))
            {
                _view.ViewReslt(User.Player);
                return;
            }
            var botIndex = GameSettings.Instance.Easy ? _model.BotStep() : _model.BotHardStep();

            if (botIndex != -1)
            {
                _view.DrowStep(botIndex);
                if (_model.IsWin(CellCondition.Cross))
                {
                    _view.ViewReslt(User.Pc);
                    return;
                }

            }
            else
            {
                _view.ViewReslt(User.None);
            }
            
        
        }
        


    }
    
}
