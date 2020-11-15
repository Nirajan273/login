using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using login.Services;
using login.Views;
using System.IO;

namespace login
{
    public partial class App : Application
    {
        static database database;

        public static database Database
        {
            get
            {
                if (database == null)
                {
                    database = new database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "people.db3"));
                }
                return database;
            }
        }
    
            public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
