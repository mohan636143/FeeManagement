using System;
using System.Collections.Generic;
using System.Windows.Input;
using FeeManagement.Infrastructure;
using FeeManagement.Models;
using FeeManagement.Views;
using Xamarin.Forms;

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

        private List<Student> _studentData;
        public List<Student> StudentData
        {
            get
            {
                return _studentData;
            }
            set
            {
                SetProperty(ref _studentData,value,"StudentData");
            }
        }

        public ICommand AddComand { get; set; }
        public ICommand ViewComand { get; set; }

        public SelectPageViewModel()
        {
            StudentData = new List<Student>()
            {
                new Student(){Name ="Student 1",Class="1"},
                new Student(){Name ="Student 2",Class="1"},
                new Student(){Name ="Student 3",Class="1"},
                new Student(){Name ="Student 4",Class="1"},
                new Student(){Name ="Student 5",Class="1"},
            };

            AddComand = new Command<Student>((obj)=>AddPaymentDetails(obj));
            ViewComand = new Command<Student>((obj)=>ViewPaymentDetails(obj));
        }

        private void AddPaymentDetails(Student student)
        {
            App.Current.MainPage = new AddPaymentPage();
        }

		private void ViewPaymentDetails(Student student)
		{
            App.Current.MainPage = new ViewFeeDetailsPage();
		}
    }
}
