using System;
using TKD_Companion_App.Services;
using TKD_Companion_App.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TKD_Companion_App
{
    public partial class App : Application
    {

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
