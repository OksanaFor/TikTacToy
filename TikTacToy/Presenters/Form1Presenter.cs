
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
            var botIndex = _model.BotStep();
            if (botIndex != -1) 
                _view.DrowStep(botIndex);
            
        
        }


    }
    
}
