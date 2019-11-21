using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using System.IO;
using System.Threading.Tasks;

namespace Example2
{
    public partial class App : Application
    {
        static LinkDatabase database;
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage(); // initializes MainPage as the main page. 
        }

        public static LinkDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new LinkDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "PDFDatabase.mdf"));
                }
                return database;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
