using BlogSystemClient.Commands;
using BlogSystemClient.Data;
using BlogSystemClient.Helpers;
using BlogSystemClient.Models;
using BlogSystemClient.Views;
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
            currentImageNumber++;
            this.Article.ImageSource = url;
        }

        public event EventHandler<SingleArticleEventArgs> OpenEditArticle;

        public event EventHandler OpenAllArticles;

        public event EventHandler<SingleArticleEventArgs> OpenAddComment;

        public event EventHandler<CommentModel> OpenAddSubComment;

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

        private ICommand backToArticles;

        public ICommand BackToArticles
        {
            get
            {
                if (this.backToArticles == null)
                {
                    this.backToArticles = new RelayCommand(this.HandleBackToArticles);
                }

                return this.backToArticles;
            }
        }

        private void HandleBackToArticles(object parameter)
        {
           
            this.OpenAllArticles(this, null);
            this.Article.ImageSource = "";
               
        }

        private ICommand addComment;

        public ICommand AddComment
        {
            get
            {
                if (this.addComment == null)
                {
                    this.addComment = new RelayCommand(this.HandleAddComment);
                }

                return this.addComment;
            }
        }

        private void HandleAddComment(object parameter)
        {

            this.OpenAddComment(this, new SingleArticleEventArgs() 
            {
                choosenArticle=this.Article
            });

        }

        private ICommand addSubComment;

        public ICommand AddSubComment
        {
            get
            {
                if (this.addSubComment == null)
                {
                    this.addSubComment = new RelayCommand(this.HandleAddSubComment);
                }

                return this.addSubComment;
            }
        }

        private void HandleAddSubComment(object parameter)
        {
            var comment=parameter as CommentModel;
            //this.OpenAddSubComment(this, comment);

            //CreateSubcommentViewModel addSubcomment = new CreateSubcommentViewModel();
            //Window windows = new Window();
            //windows.DataContext = addSubcomment;
            //windows.ShowDialog();

        }

        public string Name
        {
            get;
            set;
        }
    }
}
