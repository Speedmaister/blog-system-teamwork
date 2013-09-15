using BlogSystemClient.Commands;
using BlogSystemClient.Data;
using BlogSystemClient.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BlogSystemClient.ViewModels
{
    public class ArticlesViewModel : ViewModelBase, IPageViewModel
    {
        private string title;
        public string Name
        {
            get
            {
                return "All articles";
            }
        }

        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                this.title = value;
                this.OnPropertyChanged("Title");
            }
        }

        public ICommand Click { get; set; }

        public ObservableCollection<Article> Articles { get; set; }

        public ArticlesViewModel()
        {
            this.Articles = new ObservableCollection<Article>();
            var articles = DataPersister.GetAll();
            foreach (var article in articles)
            {
                this.Articles.Add(article);
            }
            this.Click = new RelayCommand(this.HandleClick);
        }

        public Article CurrentArticle { get; set; }

        private void HandleClick(object obj)
        {
            var a = obj as Article;
            
        }
    }
}
