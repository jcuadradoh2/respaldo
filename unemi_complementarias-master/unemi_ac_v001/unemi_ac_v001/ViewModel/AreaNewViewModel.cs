using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using unemi_ac_v001.Model;
using Xamarin.Forms;

namespace unemi_ac_v001.ViewModel
{
    public  class AreaNewViewModel:Area
    {
        public ICommand Nuevo { get;  set; }
        public ICommand Guardar { get;  set; }
        //public ICommand Modificar { get; private set; }
        public ICommand Eliminar { get;  set; }
        public ICommand Cargar { get; }
        public Command CancelarCommand { get; }
       
        public AreaNewViewModel()
        {
            //CancelarCommand = new Command(Cancelar);
            Guardar = new Command(async () =>
            {
                Area area = new Area
                {
                    Id = Id,
                    Name = Name,
                    Description = Description,
                    State = State
                };

                if (!String.IsNullOrEmpty(Name))
                {
                    if (!string.IsNullOrEmpty(Description))
                    {
                        try
                        {
                            await App.Areadb.SaveAreaAsync(area);
                            //await Shell.Current.GoToAsync("..");
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                    }

                }
               
            });

            Eliminar = new Command(async () =>
            {
                Area area = new Area
                {
                    Id = Id,
                    Name = Name,
                    Description = Description,
                    State = State
                };

                try
                {
                    await App.Areadb.DeleteAreaAsync(area);
                }
                catch (Exception)
                {

                    throw;
                }
            });

            Nuevo = new Command(() =>
            {
                Id = 0;
                Name = String.Empty;
                Description = String.Empty;
                State = true;      
            });


            //Cargar = new Command(AreasList());


        } //Ctor

        


    }
}
