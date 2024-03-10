using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTacToy.Model
{
    public static class ServerInfo
    {
        
        public static string Host = "http://localhost:5062/";

        #region Controllers
        public static string User = nameof(User);
        public static string Room = nameof(Room);
        public static string UserStatistics = nameof(UserStatistics);
        #endregion

        #region Methods


        #region Base
        public static string GetAll = nameof(GetAll);
        public static string GetById = nameof(GetById);
        public static string Update = nameof(Update);
        public static string Create = nameof(Create);
        public static string Delete = nameof(Delete);
        #endregion

        #region UserController
        public static string Registration = nameof(Registration);
        public static string Authorization = nameof(Authorization);
        #endregion


        #region UserStatisticsController
        public static string GetUserStatistics = nameof(GetUserStatistics);
        #endregion



        #endregion


        public static string CreateRequestURL(string host, string controller, string method) => host + controller + "/" + method;
    }
}
