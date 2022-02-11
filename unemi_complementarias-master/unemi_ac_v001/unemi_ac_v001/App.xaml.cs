using System;
using unemi_ac_v001.View;
using unemi_ac_v001.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using unemi_ac_v001.Vista;

namespace unemi_ac_v001
{
    public partial class App : Application
    {
        static AlumnoDB database;
        static AreaDB _areadb;


        // Create the database connection as a singleton.
        public static AlumnoDB Database
        {
            get
            {
                if (database == null)
                {
                    database = new AlumnoDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Notes.db3"));
                }
                return database;
            }
        }

        public static AreaDB Areadb 
        { 
            get 
            {
                if (_areadb == null)
                {
                    _areadb = new AreaDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Notes.db3"));
                }
                return _areadb; 
            } 
        }

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new AlumnoNew());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
