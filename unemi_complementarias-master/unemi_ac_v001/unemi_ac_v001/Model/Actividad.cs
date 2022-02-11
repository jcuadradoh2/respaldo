using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace unemi_ac_v001.Model
{
    public class Actividad:INotifyPropertyChanged
    {

        private int _id;
        private string _areaId;
        private string _nombre;
        private string _descripcion;
        private string _facultad;
        private string _estadoCurso; //Aprobado - Pendiente
        private string _fInicio;
        private string _fFin;
        private string _fInscripcion;
        private string _foto;
        private bool _state; //Activo - inactivo (para simular accion Delete)

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

        public string AreaId
        {
            get => _areaId; 
            set
            {
                _areaId = value;
                OnPropertyChanged();
            }
        }

        public string Nombre
        {
            get => _nombre; 
            set
            {
                _nombre = value;
                OnPropertyChanged();
            }
        }
        public string Descripcion
        {
            get => _descripcion; 
            set
            {
                _descripcion = value;
                OnPropertyChanged();
            }
        }
        public string Facultad
        {
            get => _facultad; 
            set
            {
                _facultad = value;
                OnPropertyChanged();
            }
        }
        public string EstadoCurso
        {
            get => _estadoCurso; 
            set
            {
                _estadoCurso = value;
                OnPropertyChanged();
            }
        }
        public string FInicio
        {
            get => _fInicio; 
            set
            {
                _fInicio = value;
                OnPropertyChanged();
            }
        }
        public string FFin
        {
            get => _fFin; 
            set
            {
                _fFin = value;
                OnPropertyChanged();
            }
        }
        public string FInscripcion
        {
            get => _fInscripcion; 
            set
            {
                _fInscripcion = value;
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

        public string Foto
        {
            get => _foto; 
            set
            {
                _foto = value;
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
