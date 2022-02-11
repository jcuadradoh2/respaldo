using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unemi_ac_v001.Model;
using unemi_ac_v001.Services;
using unemi_ac_v001.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace unemi_ac_v001.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlumnoNew : ContentPage
    {
        AlumnoNewViewModel anvm = new AlumnoNewViewModel();
        public AlumnoNew()
        {
            InitializeComponent();
            dtFechaNacimiento.MaximumDate = DateTime.Now;
            BindingContext = anvm;
        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new Alumno());
            ((NavigationPage)this.Parent).PushAsync(new Alumno());
        }
    }
}