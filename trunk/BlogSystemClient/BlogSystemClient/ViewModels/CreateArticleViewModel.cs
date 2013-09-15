using BlogSystemClient.Commands;
using BlogSystemClient.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BlogSystemClient.ViewModels
{
    public class CreateArticleViewModel : ViewModelBase
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public string Author { get; set; }

        private ICommand createCommand;

        public ICommand CreateArticle
        {
            get
            {
                if (this.createCommand == null)
                {
                    this.createCommand = new RelayCommand(this.HandleCreateArticleCommand);
                }

                return this.createCommand;
            }

        }

        private void HandleCreateArticleCommand(object obj)
        {
            var author = LoginRegisterViewModel.Username;
            var authCode = LoginRegisterViewModel.SessionKey;
            var title = this.Title;
            var content = this.Content;
            var image = this.Image;


            DataPersister.CreateArticle(author, title, content, image, authCode);
        }
    }
}
