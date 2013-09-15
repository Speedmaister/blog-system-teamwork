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

        public static void CreateArticle(string author, string title, string content, byte[] image,string sessionKey)
        {
            string loginUrl = "article/create?sessionKey=" + sessionKey;
            ArticleModel article = new ArticleModel
            {
                Author = author,
                Title = title,
                Content = content,
                Image = image
            };
            var response = requester.Post<string>(loginUrl, article);
        }


        public static int CreateComment(int articleId, string author, string content, string sessionKey)
        {
            string commentUrl = "comments/Add?sessionKey=" + sessionKey;
            CommentModel comment = new CommentModel
            {
                ArticleId = articleId,
                Author = author,
                Content = content,
                Date = DateTime.Now
            };
            var response = requester.Post<int>(commentUrl, comment);
            return response;
        }

    }
}
