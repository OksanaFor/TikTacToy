
using DTO;
using System;
using System.Threading.Tasks;
using TikTacToy.Model;
using TikTacToy.View.Interface;

namespace TikTacToy.Presenters
{
    public class RegistarationPresenter
    {
        private readonly UserDBServies _userDBServies = new UserDBServies();
        private readonly IRegistration view;
        public RegistarationPresenter(IRegistration view)
        {
           this.view = view;
            this.view.AuthorizationEvent += AuthorizationAsync;
        }
        private async void AuthorizationAsync(string login, string password)
        {
            try
            {
                UserDto userDto = new UserDto
                {

                    Login = login,
                    Password = password
                };
                //await _userDBServies.AuthorizadeUser(userDto);
                view.OpenGame();
            }
            catch(Exception ex)
            {
                view.ShowNotification(ex.Message);
            }
        }


        


    }
}
