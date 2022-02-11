using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using unemi_ac_v001.Model;
using Xamarin.Forms;

namespace unemi_ac_v001.ViewModel
{
    public class AlumnoIndexViewModel:AlumnoCls
    {
        public ObservableCollection<AlumnoCls> AlumnoList { get; }
        public Command AddAlumn { get; }
        public Command LoadAlumnCommand { get; }



        public AlumnoIndexViewModel()
        {
            LoadAlumnCommand  = new Command(async () => await LlenarAlumnAsync());
            AlumnoList = new ObservableCollection<AlumnoCls>();
            AddAlumn = new Command(DoInAdd);
        }        
                          
        public async Task LlenarAlumnAsync()
        {
            try
            {
                AlumnoList.Clear();
                var alumnList = await App.Database.GetAlumnAsync();
                foreach (var item in alumnList)
                {
                    AlumnoList.Add(item);
                }
            }
            catch (Exception)
            {
                throw;
            }            
        }
        private void DoInAdd()
        {
           Shell.Current.GoToAsync(nameof(unemi_ac_v001.View.AlumnoNew));
        }

        /// <summary>
        /// Correccion del metodo llenar
        /// </summary>
       
        private ObservableCollection<AlumnoCls> alum;
        public ObservableCollection<AlumnoCls> Alum
        {
            get
            {
                LoadAlumno();
                return alum;
            }
            set
            {
                alum = value;
            }

        }

        
        async void LoadAlumno()
        {
            try
            {
                ObservableCollection<AlumnoCls> model = new ObservableCollection<AlumnoCls>(await App.Database.GetAlumnAsync());
                alum = new ObservableCollection<AlumnoCls>();
                foreach (var i in model)
                {
                    alum.Add(i);
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

    }
}
