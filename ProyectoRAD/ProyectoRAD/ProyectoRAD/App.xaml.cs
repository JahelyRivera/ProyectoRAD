using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoRAD
{
    public partial class App : Application
    {
        static Controllers.DBRegistros dBRegistros;

        public static Controllers.DBRegistros dbregistros
        {
            get
            {
                if (dBRegistros == null)
                {
                    string DBName = "contactos.db3";
                    string PathDB = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DBName);
                    dBRegistros = new Controllers.DBRegistros(PathDB);
                }

                return dBRegistros;
            }
        }

        public static MasterDetailPage MasterDet { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();

            //MainPage = new NavigationPage(new Views.Master());
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
