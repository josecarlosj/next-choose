using System;
using System.IO;
using NextChoose.Data;
using Xamarin.Forms;

namespace NextChoose
{
    public partial class App : Application
    {
        static OptionDatabase database;

        // Create the database connection as a singleton.
        public static OptionDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new OptionDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Options.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
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
