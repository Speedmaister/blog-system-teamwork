using BlogSystemClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BlogSystemClient.Data
{
    public class DataPersister
    {
        private const string BaseUrl = "http://blogsystem-1.apphb.com/api/";
        private static HttpRequester requester = new HttpRequester(BaseUrl);

        public static void RegisterUser(string username, string authCode)
        {
            string registerUrl = "users/register";
            UserModel user = new UserModel
            {
                Username = username,
                Password = authCode
            };
            var response = requester.Post<SessionKeyModel>(registerUrl, user);
        }

        public static void LoginUser(string username, string authCode)
        {
            string loginUrl = "users/login";
            UserModel user = new UserModel
            {
                Username = username,
                Password = authCode
            };
            var response = requester.Post<SessionKeyModel>(loginUrl, user);
        }
    }
}
