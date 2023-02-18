using System;
using System.Collections.Generic;
using TKD_Companion_App.ViewModels;
using TKD_Companion_App.Views;
using Xamarin.Forms;

namespace TKD_Companion_App
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(WhiteBeltWords), typeof(WhiteBeltWords));
            Routing.RegisterRoute(nameof(YellowTagWords), typeof(YellowTagWords));
            Routing.RegisterRoute(nameof(YellowBeltWords), typeof(YellowBeltWords));
            Routing.RegisterRoute(nameof(GreenTagWords), typeof(GreenTagWords));
            Routing.RegisterRoute(nameof(GreenBeltWords), typeof(GreenBeltWords));
            //Routing.RegisterRoute(nameof(BlueTagWords), typeof(BlueTagWords));
            //Routing.RegisterRoute(nameof(BlueBeltWords), typeof(BlueBeltWords));
            //Routing.RegisterRoute(nameof(RedTagWords), typeof(RedTagWords));
            //Routing.RegisterRoute(nameof(RedBeltWords), typeof(RedBeltWords));
            //Routing.RegisterRoute(nameof(BlackTagWords), typeof(BlackTagWords));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
