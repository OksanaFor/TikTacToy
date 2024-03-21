using DTO;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System;


namespace TikTacToy.Model
{
    public class RoomDbServise: BaseDBService<RoomDto, int>
    {
        public async Task EnterRoom(RoomDto room)
        {
            var url = ServerInfo.CreateRequestURL(ServerInfo.Host, controllerName, ServerInfo.Registration);

            var serData = JsonConvert.SerializeObject(room);
            var stringContent = new StringContent(serData, Encoding.UTF8, "application/json");

            using (var client = new HttpClient())
            {
                var response = await client.PostAsync(url, stringContent);
                if (response.IsSuccessStatusCode)
                {
                    var data = JsonConvert.DeserializeObject<Tuple<string, RoomDto>>((await response.Content.ReadAsStringAsync()));
                    AccessVerifivation.Instance.Token = data.Item1;
                    //AccessVerifivation.Instance.CurrentUser = data.Item2;
                }
                else
                    throw new Exception(
                        JsonConvert.DeserializeObject<Exception>(await response.Content.ReadAsStringAsync()).Message
                        );
            }
        }
}
