using DTO;
using DTO.Request;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TikTacToy.Model
{
    public class UserDBServies : BaseDBService<UserDto,int>
    {
        public async Task RegistrationUser(UserDto user)
        {
            var url = ServerInfo.CreateRequestURL(ServerInfo.Host, controllerName, ServerInfo.Registration);

            var serData = JsonConvert.SerializeObject(user);
            var stringContent = new StringContent(serData, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                var response = await client.PostAsync(url, stringContent);
                if (response.IsSuccessStatusCode)
                {
                    var data = JsonConvert.DeserializeObject<Tuple<string, UserDto>>((await response.Content.ReadAsStringAsync()));
                    AccessVerifivation.Instance.Token = data.Item1;
                    AccessVerifivation.Instance.CurrentUser = data.Item2;
                }
                else
                    throw new Exception(
                        JsonConvert.DeserializeObject<Exception>(await response.Content.ReadAsStringAsync()).Message
                        );
            }
        }

        public async Task AuthorizadeUser(AuthorizationDto user)
        {

            var url = ServerInfo.CreateRequestURL(ServerInfo.Host, controllerName, ServerInfo.Authorization);

            var serData = JsonConvert.SerializeObject(user);
            var stringContent = new StringContent(serData, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                var response = await client.PostAsync(url, stringContent);
                if (response.IsSuccessStatusCode)
                {
                    var data = JsonConvert.DeserializeObject<Tuple<string, UserDto>>((await response.Content.ReadAsStringAsync()));
                    AccessVerifivation.Instance.Token = data.Item1;
                    AccessVerifivation.Instance.CurrentUser = data.Item2;

                }
                else
                    throw new Exception(
                        JsonConvert.DeserializeObject<Exception>(await response.Content.ReadAsStringAsync()).Message
                        );
            }
         
        }
    }
}
