using System;


namespace TikTacToy.View.Interface
{
    public interface IForm1
    {
        event Action<float> StartGameEvent;
        event Action<int> ClickEvent;
        void DrowStep (int index);
    }
    
    
}
