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
        private IPageViewModel currenViewModel;

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
            this.ViewModels.Add(this.LoginRegisterViewModel);
            this.CurrentViewModel = this.LoginRegisterViewModel;
        }
    }
}
