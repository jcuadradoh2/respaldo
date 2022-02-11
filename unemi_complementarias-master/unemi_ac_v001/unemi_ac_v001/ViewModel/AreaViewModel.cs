using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using unemi_ac_v001.Model;
using unemi_ac_v001.View;
using Xamarin.Forms;

namespace unemi_ac_v001.ViewModel
{
    public class AreaViewModel:Area
    {
        
        //public NavigationPage Navigation { get; set; }
        //public Command AreaTappedDel { get; set; }  
        
        public AreaViewModel()
        {
            //AreaTappedDel = new Command(OnDelete);
            //AddCommand = new Command(NuevoCommand);
            
        }
        private ObservableCollection<Area> areas;
        public ObservableCollection<Area> AreasList
        {
            get
            {
                LoadArea();
                return areas;
            }
            set
            {
                areas = value;  
            }

        }

        void LoadArea()
        {
            try
            {
                ObservableCollection<Area> model = new ObservableCollection<Area>(App.Areadb.GetAreaList());
                areas = new ObservableCollection<Area>();
                foreach (var i in model)
                {
                    areas.Add(i);
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
        
    
    }
}
