﻿using BlogSystemClient.Commands;
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

        public MasterViewModel()
        {
            this.LoginRegisterViewModel = new LoginRegisterViewModel();
            this.LoginRegisterViewModel.LoginRegisterSuccess += this.NavigateToHome;
            this.CreateArticleViewModel = new CreateArticleViewModel();
            this.CreateCommentViewModel = new CreateCommentViewModel();
            this.ArticlesViewModel = new ArticlesViewModel();
            this.CreateSubcommentViewModel = new CreateSubcommentViewModel();
            this.CurrentViewModel = this.LoginRegisterViewModel;
        }

    }
}