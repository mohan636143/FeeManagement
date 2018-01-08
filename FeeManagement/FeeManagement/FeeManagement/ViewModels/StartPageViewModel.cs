using System;
using System.Windows.Input;
using FeeManagement.Infrastructure;
using FeeManagement.Views;
using Xamarin.Forms;

namespace FeeManagement.ViewModels
{
    public class StartPageViewModel : ViewModelBase
    {

		public ICommand FeeCommand { get; set; }

        public StartPageViewModel()
        {
            FeeCommand = new Command((obj) =>
            {
                Application.Current.MainPage = new SelectPage();
            });
        }
    }
}
