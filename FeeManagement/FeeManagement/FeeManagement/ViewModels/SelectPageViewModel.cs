using System;
using System.Collections.Generic;
using FeeManagement.Infrastructure;
using FeeManagement.Models;

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
        }
    }
}
