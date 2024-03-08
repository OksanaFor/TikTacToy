using System;


namespace TikTacToy.View.Interface
{
    public interface IRegistration :IBaseView
    {
        event Action<string,string> RegisterationEvent;
        event Action<string,string> AuthorizationEvent;
        void OpenGame();
    }

}
