using BlogSystemClient.Commands;
using BlogSystemClient.Data;
using BlogSystemClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace BlogSystemClient.ViewModels
{
    public class CreateCommentViewModel : ViewModelBase, IPageViewModel
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public int ArticleId { get; set; }

        private ICommand createCommentCommand;

        public ICommand CreateComment
        {
            get
            {
                if (this.createCommentCommand == null)
                {
                    this.createCommentCommand = new RelayCommand(this.HandleCreateCommentCommand);
                }

                return this.createCommentCommand;
            }
        }

        private void HandleCreateCommentCommand(object parameter)
        {
            var content = this.Content;
            var author = LoginRegisterViewModel.Username;
            var sessionKey = LoginRegisterViewModel.SessionKey;
            var article = this.ArticleId;

            this.Id = DataPersister.CreateComment(article, author, content, sessionKey);
        }

        public string Name
        {
            get { return "Create comment form"; }
        }
    }
}
