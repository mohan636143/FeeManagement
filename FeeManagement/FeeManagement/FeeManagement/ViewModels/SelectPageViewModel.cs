using System;
using FeeManagement.Infrastructure;
namespace FeeManagement.ViewModels
{
    public class SelectPageViewModel : ViewModelBase
    {
        private bool _isBusy;
        public bool IsBusy
        {
            get
            {
                return _isBusy;
            }
            set
            {
                _isBusy = value;
                SetProperty(ref _isBusy, value, "IsBusy");
            }
        }

        public SelectPageViewModel()
        {
        }
    }
}
