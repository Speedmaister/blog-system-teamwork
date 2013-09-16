using BlogSystemClient.Commands;
using BlogSystemClient.Data;
using BlogSystemClient.Helpers;
using BlogSystemClient.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace BlogSystemClient.ViewModels
{
    public class SingleArticleViewModel : ViewModelBase, IPageViewModel
    {
        private static int currentImageNumber = 1;
        public Article Article
        {
            get;
            set;
        }

        public SingleArticleViewModel()
        {

        }

        public void SetArticle(Article article)
        {
            this.Article = article;
            this.SaveImageToComputer();
        }

        private void SaveImageToComputer()
        {
            string savePath = @"..\..\Images\" + currentImageNumber+".jpg";
            var url = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), savePath);
            MemoryStream stream = new MemoryStream(this.Article.Images[0].Image);
            var image = Image.FromStream(stream);
            image.Save(savePath, System.Drawing.Imaging.ImageFormat.Jpeg);
            this.Article.ImageSource = url;
        }

        public event EventHandler<SingleArticleEventArgs> OpenEditArticle;

        private ICommand editCommand;

        public ICommand EditArticle
        {
            get
            {
                if (this.editCommand == null)
                {
                    this.editCommand = new RelayCommand(this.HandleEditCommand);
                }

                return this.editCommand;
            }
        }

        private void HandleEditCommand(object parameter)
        {
            this.OpenEditArticle(this, new SingleArticleEventArgs()
            {
                choosenArticle = this.Article
            });
        }

        public string Name
        {
            get;
            set;
        }
    }
}
