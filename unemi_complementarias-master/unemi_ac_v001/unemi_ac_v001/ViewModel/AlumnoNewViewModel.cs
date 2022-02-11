using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using unemi_ac_v001.Model;
using unemi_ac_v001.Data;
using Xamarin.Forms;

namespace unemi_ac_v001.ViewModel
{
    public class AlumnoNewViewModel:AlumnoCls
    {
        public ICommand Guardar { get; private set; }
        public ICommand Modificar { get; private set; }
        public ICommand Eliminar { get; private set; }
        public ICommand Nuevo { get; private set; }

        public AlumnoNewViewModel()
        {
            Guardar = new Command(async () =>
            {
                AlumnoCls alumno = new AlumnoCls()
                {
                    Name = Name,
                    Lastname = Lastname,
                    Cedula = Cedula,
                    Email = Email,
                    FNacimiento = FNacimiento,
                    Foto = Foto,
                    Telefono = Telefono

                };

                await App.Database.SaveAlumnAsync(alumno);
                //await Shell.Current.GoToAsync(nameof(unemi_ac_v001.ViewModel.AlumnoIndexViewModel));
            });

            Modificar = new Command(async () =>
            {
                AlumnoCls alumno = new AlumnoCls()
                {
                    Name = Name,
                    Lastname = Lastname,
                    Cedula= Cedula,
                    Email = Email,
                    FNacimiento = FNacimiento,
                    Foto = Foto,
                    Telefono = Telefono,
                    Id = Id,
                };
                await App.Database.SaveAlumnAsync(alumno);
            }); 
            
            Eliminar = new Command(async () =>
            {
                AlumnoCls alumno = new AlumnoCls()
                {
                    Name = Name,
                    Lastname = Lastname,
                    Cedula = Cedula,
                    Email = Email,
                    FNacimiento = FNacimiento,
                    Foto = Foto,
                    Telefono = Telefono,
                    Id = Id,
                };
                await App.Database.SaveAlumnAsync(alumno);
            });
            
            Nuevo = new Command(() =>
            {
                Name = String.Empty;
                Lastname = String.Empty;
                Cedula = String.Empty;
                Email = String.Empty;
                FNacimiento = DateTime.Now;
                Foto = "/avatar_white.png";
                Telefono = String.Empty;                     
            });

        }
    }
}
