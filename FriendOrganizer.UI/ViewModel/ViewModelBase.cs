﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FriendOrganizer.UI.ViewModel
{
    public class ViewModelBase: INotifyPropertyChanged
    {
        public ViewModelBase()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
