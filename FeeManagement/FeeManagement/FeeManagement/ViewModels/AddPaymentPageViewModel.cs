using System;
using System.Windows.Input;
using FeeManagement.Infrastructure;
using FeeManagement.Views;
using Xamarin.Forms;

namespace FeeManagement.ViewModels
{
    public class AddPaymentPageViewModel : ViewModelBase
    {

        private DateTime _date;
        public DateTime PaymentDate
        {
            get
            {
                return _date;
            }
            set
            {
                SetProperty(ref _date,value,"PaymentDate");
            }
        }

        private string _towards;
		public string Towards
		{
			get
			{
				return _towards;
			}
			set
			{
				SetProperty(ref _towards, value, "Towards");
			}
		}

		private string _mode;
		public string Mode
		{
			get
			{
				return _mode;
			}
			set
			{
				SetProperty(ref _mode, value, "Mode");
			}
		}

		private string _amount;
		public string Amount
		{
			get
			{
				return _amount;
			}
			set
			{
				SetProperty(ref _amount, value, "Amount");
			}
		}

        public ICommand UpdateCommand { get; set; }

        public AddPaymentPageViewModel()
        {
            UpdateCommand = new Command(UpdateData);
        }

        private void UpdateData()
        {
            App.Current.MainPage = new ViewFeeDetailsPage();
        }
    }
}
