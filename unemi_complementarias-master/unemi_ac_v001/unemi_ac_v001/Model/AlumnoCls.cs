using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace unemi_ac_v001.Model
{

    public class AlumnoCls:INotifyPropertyChanged
    {   

        private int _id;
        private string _name;
        private string _lastname;
        private string _cedula;
        private string _email;
        private DateTime _fNacimiento;
        private string _foto;
        private string _telefono;

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
        public string Lastname
        {
            get => _lastname; 
            set
            {
                _lastname = value;
                OnPropertyChanged();
            }
        }
        public DateTime FNacimiento
        {
            get => _fNacimiento; 
            set
            {
                _fNacimiento = value;
                OnPropertyChanged();
            }
        }
        public string Foto
        {
            get => _foto; 
            set
            {
                _foto = value;
                OnPropertyChanged();
            }
        }

        public string Telefono
        {
            get => _telefono; 
            set
            {
                    _telefono = value;
                    OnPropertyChanged();
            }
        }

        public string Email
        {
            get => _email; 
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }

        public string Cedula
        {
            get => _cedula; 
            set
            {
                _cedula = value;
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
