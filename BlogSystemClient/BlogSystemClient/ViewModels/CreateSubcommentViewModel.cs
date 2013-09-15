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
    public class CreateSubcommentViewModel : ViewModelBase, IPageViewModel
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public int ParentCommentId { get; set; }

        private ICommand createSubcommentCommand;

        public ICommand CreateSubcomment
        {
            get
            {
                if (this.createSubcommentCommand == null)
                {
                    this.createSubcommentCommand = new RelayCommand(this.HandleCreateSubcommentCommand);
                }

                return this.createSubcommentCommand;
            }
        }

        private void HandleCreateSubcommentCommand(object parameter)
        {
            var content = this.Content;
            var author = "radoslav92"; //LoginRegisterViewModel.Username;
            var sessionKey = "41B90fY4fG691aWi7cbsPNbzHOxeOG89p7h2LPaq"; //LoginRegisterViewModel.SessionKey;
            var parent = 1; //this.ParentCommentId;

            this.Id = DataPersister.CreateSubcomment(parent, author, content, sessionKey);
        }

        public string Name
        {
            get { return "Create subcomment form"; }
        }
    }
}
