using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TKD_Companion_App.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About ITF";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://itftkd.sport/about-us/"));
        }

        public ICommand OpenWebCommand { get; }
    }
}