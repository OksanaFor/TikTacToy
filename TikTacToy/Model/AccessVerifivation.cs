using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTacToy.Model
{
    public class AccessVerifivation
    {
        public string Token { get; set; }
        public UserDto CurrentUser { get; set; }

        private static AccessVerifivation _instance;

        private AccessVerifivation()
        {
        }

        public static AccessVerifivation Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AccessVerifivation();
                return _instance;
            }
        }

        public bool SuccessVerifivation() => Token != null;
    }
}
