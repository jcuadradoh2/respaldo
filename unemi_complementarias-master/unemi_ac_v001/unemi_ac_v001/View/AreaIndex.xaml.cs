using System;
using System.Collections.Generic;
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
    public partial class AreaIndex : ContentPage
    {
        AreaViewModel _avv = new AreaViewModel();
        public AreaIndex()
        {
            InitializeComponent();
            try
            {
                BindingContext = _avv;
            }
            catch (Exception e)
            {
                DisplayAlert("", e.Message, "Ok");
                
            }
            
            cargar();

            //cargar_lista();

        }

        async void cargar_lista()
        {
            List<Area> lista = new List<Area>();              
            lista = await App.Areadb.GetAreaAsync();
            clvArea.ItemsSource = lista;
        }

        private void btnVer_Clicked(object sender, EventArgs e)
        {
            cargar();
        }
        void cargar()
        {
            List<Area> _a = App.Areadb.GetAreaList();
            clvArea.ItemsSource = _a;                        
        }
        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            //List<Area> areaList = await App.Areadb.GetByNameAsync(txtArea.Text);
            //var _area = new Area();
            
            //if (areaList!=null)
            //{
            //    foreach (var item in areaList)
            //    {
            //        _area.Id = item.Id;
            //    }
            //}
            
            //_area.Name = txtArea.Text;
            //_area.Description = txtDescripcion.Text;
            //_area.State = cbxEstado.IsChecked;                        
            
            //await App.Areadb.SaveAreaAsync(_area);          
            
        }
       

        private void clvArea_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //var area = e.CurrentSelection;

            //if (area != null)
            //{

            //    for (int i = 0; i < area.Count; i++)
            //    {
            //        Area _a = new Area();
            //        var per = area[i] as Area;
            //        txtId.Text = per.Id.ToString();
            //        txtArea.Text= per.Name;
            //        txtDescripcion.Text = per.Description;
            //        cbxEstado.IsChecked = per.State;



            //    }
            //}

            //((NavigationPage)this.Parent).PushAsync(new AreaNew());

            var area = e.CurrentSelection;

            if (area!=null)
            {
                foreach (var item in area)
                {
                    Area model = (Area)item;
                    _avv.Id = model.Id;
                    _avv.Name = model.Name;
                    _avv.Description = model.Description;
                    _avv.State = model.State;
                    ((NavigationPage)Parent).PushAsync(new AreaNew(_avv));
                }
               
                      
            }

        }

        private void btnEliminar_Clicked(object sender, EventArgs e)
        {


        }

        private void btnAdd_Clicked(object sender, EventArgs e)
        {
            _avv = new AreaViewModel();
            ((NavigationPage)Parent).PushAsync(new AreaNew(_avv));

        }
    }
}