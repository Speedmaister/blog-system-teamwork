using BlogSystemClient.Data;
using BlogSystemClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSystemClient.ViewModels
{
    public class SingleArticleViewModel : ViewModelBase, IPageViewModel
    {
        public Article Article;


        public SingleArticleViewModel(int articleId)
        {
            this.Article = DataPersister.GetArticleById(articleId);

        }

        public string Name
        {
            get { throw new NotImplementedException(); }
        }
    }
}
