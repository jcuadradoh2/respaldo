using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace unemi_ac_v001.Model
{
    public class Area:INotifyPropertyChanged
    {
        private int _id;
        private string _name;        
        private string _description;
        private bool _state = true;

        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get => _id; 
            set
            {
                _id = value;
                OnPropertyChanged();
            }
        }
        public string Name
        {
            get => _name; 
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }
        public string Description
        {
            get => _description; 
            set
            {
                _description = value;
                OnPropertyChanged();
            }
        }

        public bool State
        {
            get => _state; 
            set
            {
                _state = value;
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
