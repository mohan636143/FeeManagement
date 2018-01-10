using System;
using System.Collections.Generic;
using FeeManagement.Infrastructure;
using FeeManagement.Models;

namespace FeeManagement.ViewModels
{
    public class ViewFeeDetailsPageViewModel : ViewModelBase
    {
        private List<Payment> _paymentList;
        public List<Payment> PaymentList
        {
            get
            {
                return _paymentList;
            }
            set
            {
                SetProperty(ref _paymentList, value,"PaymentList");
            }
        }

        private string _childName;
        public string ChildName
		{
			get
			{
				return _childName;
			}
			set
			{
				SetProperty(ref _childName, value, "ChildName");
			}
		}

		private string _className;
		public string ClassName
		{
			get
			{
				return _className;
			}
			set
			{
				SetProperty(ref _className, value, "ClassName");
			}
		}

        private DateTime _joinDate;
        public DateTime JoinDate
		{
			get
			{
				return _joinDate;
			}
			set
			{
				SetProperty(ref _joinDate, value, "JoinDate");
			}
		}

		private string _totalFee;
		public string TotalFee
		{
			get
			{
				return _totalFee;
			}
			set
			{
				SetProperty(ref _totalFee, value, "TotalFee");
			}
		}

		private string _totalPaid;
		public string TotalPaid
		{
			get
			{
				return _totalPaid;
			}
			set
			{
				SetProperty(ref _totalPaid, value, "TotalPaid");
			}
		}

        private string _balance;
		public string Balance
		{
			get
			{
				return _balance;
			}
			set
			{
				SetProperty(ref _balance, value, "Balance");
			}
		}

        public ViewFeeDetailsPageViewModel()
        {
            ChildName = "Child 1";
            ClassName = " Class 1";
            JoinDate = DateTime.Today;
            TotalFee = "10000";
            TotalPaid = "2500";

            PaymentList = new List<Payment>()
            {
                new Payment(){PaymentDate = DateTime.Today,Towards = "Term 1", Mode="Cash",Amount="1000"},
                new Payment(){PaymentDate = DateTime.Today,Towards = "Term 2", Mode="DD",Amount="5000"},
                new Payment(){PaymentDate = DateTime.Today,Towards = "Term 3", Mode="Cheque",Amount="1000"},
                new Payment(){PaymentDate = DateTime.Today,Towards = "Term 4", Mode="Online",Amount="500"}
            };
        }
    }
}
