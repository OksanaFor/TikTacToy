using System;


namespace TikTacToy.View.Interface
{
    public interface ISettings
    {
        event Action<bool> OnChoiseLevel;
        void Initialize(bool level);
    }
}
