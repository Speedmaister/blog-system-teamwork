using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSystemClient.ViewModels
{
    public class MasterViewModel : ViewModelBase
    {
        private IPageViewModel loginRegisterViewModel;
        public IPageViewModel createArticleViewModel;
        private IPageViewModel createSubcommentViewModel;
        private IPageViewModel createCommentViewModel;
        private IPageViewModel currenViewModel;
        private IPageViewModel articlesViewModel;

        public List<IPageViewModel> ViewModels
        {
            get;
            set;
        }

        public IPageViewModel LoginRegisterViewModel
        {
            get
            {
                return loginRegisterViewModel;
            }
        }

        public IPageViewModel ArticlesViewModel
        {
            get 
            {
                return articlesViewModel;
            }
        }

        public IPageViewModel CreateArticleViewModel
        {
            get
            {
                return createArticleViewModel;
            }
        }

        public IPageViewModel CreateCommentViewModel
        {
            get
            {
                return createCommentViewModel;
            }
        }

        public IPageViewModel CreateSubcommentViewModel
        {
            get
            {
                return createSubcommentViewModel;
            }
        }

        public IPageViewModel CurrentViewModel
        {
            get
            {
                return this.currenViewModel;
            }
            set
            {
                this.currenViewModel = value;
                OnPropertyChanged("CurrentViewModel");
            }
        }

        public MasterViewModel()
        {
            this.ViewModels = new List<IPageViewModel>();
            this.loginRegisterViewModel = new LoginRegisterViewModel();
            this.createArticleViewModel = new CreateArticleViewModel();
            this.createCommentViewModel = new CreateCommentViewModel();
            this.articlesViewModel = new ArticlesViewModel();
            this.createSubcommentViewModel = new CreateSubcommentViewModel();
            this.ViewModels.Add(this.LoginRegisterViewModel);
            this.ViewModels.Add(this.CreateArticleViewModel);
            this.ViewModels.Add(this.CreateCommentViewModel);
            this.ViewModels.Add(this.CreateSubcommentViewModel);
            this.ViewModels.Add(this.ArticlesViewModel);

            this.CurrentViewModel = this.ArticlesViewModel;
        }

        
    }
}
