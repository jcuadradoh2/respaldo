using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using unemi_ac_v001.Model;
using Xamarin.Forms;

namespace unemi_ac_v001.ViewModel
{
    public class LoginViewModel: Login
    {
        public ICommand LogIn { get; set; }
        public LoginViewModel()
        {            
            LogIn = new Command(async () =>
            {
                Login log = new Login
                {
                   UserName = UserName,
                   Password = Password
                };

                try
                {
                    await Task.Delay(1000);
                    App.Areadb.LogIn(log);
                }
                catch (Exception)
                {

                    throw;
                }
            });
        }

        
    }
}
