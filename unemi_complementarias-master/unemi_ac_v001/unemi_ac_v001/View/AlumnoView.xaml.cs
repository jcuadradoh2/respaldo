using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using unemi_ac_v001.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace unemi_ac_v001.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Alumno : ContentPage
    {
        AlumnoIndexViewModel aivm = new AlumnoIndexViewModel(); 
        public Alumno()
        {
            InitializeComponent();
            
            BindingContext =  aivm;
            Cargar();
            
        }


        void Cargar()
        {
            List<Model.AlumnoCls> _a = App.Database.GetAlumnoList();
            clvAlumno.ItemsSource = _a;
        }


        private void btnNuevo_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new AlumnoNew());
        }
    }
}