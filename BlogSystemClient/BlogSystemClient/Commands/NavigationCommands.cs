using BlogSystemClient.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BlogSystemClient.Commands
{
    public class NavigationCommands
    {
        private MasterViewModel masterViewModel;

        public NavigationCommands(MasterViewModel masterViewModel)
        {
            this.masterViewModel = masterViewModel;
        }

        public void HandleLoadHomePageCommand(object obj)
        {
            this.NavigateTo(this.masterViewModel.ArticlesViewModel);
        }

        private void NavigateTo(IPageViewModel viewModel)
        {
            this.masterViewModel.CurrentViewModel = viewModel;
        }
    }
}
