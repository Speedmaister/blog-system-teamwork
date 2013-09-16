using BlogSystemClient.Commands;
using BlogSystemClient.Helpers;
using BlogSystemClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSystemClient.ViewModels
{
    public class MasterViewModel : ViewModelBase
    {
        private IPageViewModel currentViewModel;
        public LoginRegisterViewModel LoginRegisterViewModel { get; set; }

        public ArticlesViewModel ArticlesViewModel { get; set; }

        public CreateArticleViewModel CreateArticleViewModel { get; set; }

        public CreateCommentViewModel CreateCommentViewModel { get; set; }

        public CreateSubcommentViewModel CreateSubcommentViewModel { get; set; }

        public EditArticleViewModel EditArticleViewModel { get; set; }

        public SingleArticleViewModel SingleArticleViewModel { get; set; }

        public IPageViewModel CurrentViewModel
        {
            get
            {
                return this.currentViewModel;
            }
            set
            {
                this.currentViewModel = value;
                OnPropertyChanged("CurrentViewModel");
            }
        }

        public void NavigateToHome(object sender, EventArgs e)
        {
            this.CurrentViewModel = this.ArticlesViewModel;
        }

        public void NavigateToLoginRegister(object sender, EventArgs e)
        {
            this.CurrentViewModel = this.LoginRegisterViewModel;
        }

        public void NavigateToSingleArticle(object sender, SingleArticleEventArgs e)
        {
            this.CurrentViewModel = this.SingleArticleViewModel;
            this.SingleArticleViewModel.SetArticle(e.choosenArticle);
        }

        public void NavigateToCreateArticle(object sender, EventArgs e)
        {
            this.CurrentViewModel = this.CreateArticleViewModel;
        }

        public void NavigateToEditArticle(object sender, SingleArticleEventArgs e)
        {
            //TODO Change view to edit article
            this.CurrentViewModel = this.EditArticleViewModel;
            this.EditArticleViewModel.SetChoosenArticle(e.choosenArticle);
        }

        public void NavigateToCreateSubcomment(object sender, EventArgs e)
        {
            this.CurrentViewModel = this.CreateSubcommentViewModel;
        }

        public void NavigateToCreateComment(object sender, EventArgs e)
        {
            this.CurrentViewModel = this.CreateCommentViewModel;
        }


        public MasterViewModel()
        {
            this.LoginRegisterViewModel = new LoginRegisterViewModel();
            this.LoginRegisterViewModel.LoginRegisterSuccess += this.NavigateToHome;

            this.CreateArticleViewModel = new CreateArticleViewModel();
            this.CreateArticleViewModel.CreateArticleSuccess += this.NavigateToHome;

            this.CreateCommentViewModel = new CreateCommentViewModel();
            this.ArticlesViewModel = new ArticlesViewModel();
            this.ArticlesViewModel.homePageSuccess += this.NavigateToSingleArticle;
            this.ArticlesViewModel.OpenCreateArticle += this.NavigateToCreateArticle;
            this.SingleArticleViewModel = new SingleArticleViewModel();
            this.SingleArticleViewModel.OpenEditArticle += this.NavigateToEditArticle;
            this.EditArticleViewModel = new EditArticleViewModel();
            this.EditArticleViewModel.EditArticleSuccess += this.NavigateToSingleArticle;
            this.CreateSubcommentViewModel = new CreateSubcommentViewModel();
            this.CurrentViewModel = this.LoginRegisterViewModel;
        }

    }
}
