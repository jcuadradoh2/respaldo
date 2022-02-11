using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unemi_ac_v001.Model;
using unemi_ac_v001.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace unemi_ac_v001.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AreaNew : ContentPage
    {
        AreaNewViewModel viewModel = new AreaNewViewModel(); 
        public AreaNew(AreaViewModel avm)
        {
           
            InitializeComponent();
            viewModel.Id = avm.Id;
            viewModel.Name = avm.Name;
            viewModel.Description = avm.Description;
            viewModel.State = avm.State;
            this.BindingContext = viewModel;

        }
      
        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            AreaViewModel areaViewModel = new AreaViewModel();
            try
            {
                ObservableCollection<Area> model = new ObservableCollection<Area>(App.Areadb.GetAreaList());
                areaViewModel.AreasList = new ObservableCollection<Area>();
                foreach (var i in model)
                {
                    areaViewModel.AreasList.Add(i);
                }
            }
            catch (Exception)
            {
                throw;
            }
             DisplayAlert("Mensaje", "Datos guardados correctamente", "Ok");
             ((NavigationPage)Parent).PushAsync(new AreaIndex());
        }

        private void btnCancelar_Clicked(object sender, EventArgs e)
        {

            ((NavigationPage)Parent).PushAsync(new AreaIndex());

        }

        private void btnEliminar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Mensaje", "Datos eliminados correctamente", "Ok");

            ((NavigationPage)Parent).PushAsync(new AreaIndex());
        }
    }
}