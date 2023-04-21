using System;
using ExamenFinalApp.Services;
using ExamenFinalApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamenFinalApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            
            MainPage = new NavigationPage(new BienvenidaPage());
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
