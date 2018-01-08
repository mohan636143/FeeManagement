﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FeeManagement.Infrastructure
{
	public class ViewModelBase : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChangedEventHandler handler = PropertyChanged;

			if (handler != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
		{
		  if (Object.Equals(storage, value))
		      return false;
		  else
		  {
		      storage = value;
		      OnPropertyChanged(propertyName);
		      return true;
		  }
		}
	}
}
