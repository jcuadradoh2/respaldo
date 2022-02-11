using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace unemi_ac_v001.Model
{
    public class Login: INotifyPropertyChanged
    {
        private string _username;
        private string _password;

        public string UserName
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
