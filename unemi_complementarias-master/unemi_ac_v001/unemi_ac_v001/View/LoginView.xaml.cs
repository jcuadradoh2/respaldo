using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using unemi_ac_v001.ViewModel;
using unemi_ac_v001.Model;
using unemi_ac_v001.View;

namespace unemi_ac_v001.Vista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : ContentPage
    {
        LoginViewModel vm = new LoginViewModel();
        public LoginView()
        {
            InitializeComponent();            
            SizeChanged += MainPageSizeChanged;    
            BindingContext = vm;
        }

        private void MainPageSizeChanged(object sender, EventArgs e)
        {
            
            bool isPortrait = this.Width > this.Height;
            if (isPortrait)
            {
                //DisplayAlert("Hola", "", "Ok");
                
                frmMain.Margin = new Thickness(150,0,150,0);
                //btnLogin.Margin = new Thickness(100,0,100,0);
                
            }
            else
            {
                frmMain.Margin = new Thickness(15,15,15,15);
                
            }

        }

        private void btnLinkedIn_Clicked(object sender, EventArgs e)
        {            
            Browser.OpenAsync("https://www.linkedin.com/school/unemiecuador", BrowserLaunchMode.SystemPreferred);
        }

        private void btnFacebook_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.facebook.com/UNEMIEcuador", BrowserLaunchMode.SystemPreferred);
        }

        private void btnGoogle_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("http://www.unemi.edu.ec/", BrowserLaunchMode.SystemPreferred);
        }

        private void btnLogin_Clicked(object sender, EventArgs e)
        {           
            var res = App.Areadb.LogIn(vm);
            if (!String.IsNullOrEmpty(vm.UserName))
            {
                if (!String.IsNullOrEmpty(vm.Password))
                {
                    if (res)
                    {
                        ((NavigationPage)Parent).PushAsync(new AreaIndex());
                    }
                }
                else
                {
                    DisplayAlert("Alerta", "El campo *contraseña* esta vacio", "Ok");

                }
            }
            else
            {
                DisplayAlert("Alerta", "El campo usuario esta vacio", "Ok");
            }
            
        }
    }
}