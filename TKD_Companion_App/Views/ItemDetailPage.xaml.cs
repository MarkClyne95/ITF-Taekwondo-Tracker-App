using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TKD_Companion_App.ViewModels;
using Xamarin.Forms;

namespace TKD_Companion_App.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();

            Name.PropertyChanged += CheckBelt;
            WhiteBelt.Clicked += WhiteBelt_Clicked;
            YellowTag.Clicked += YellowTag_Clicked;
            YellowBelt.Clicked += YellowBelt_Clicked;
            GreenTag.Clicked += GreenTag_Clicked;
            GreenBelt.Clicked += GreenBelt_Clicked;
            BlueTag.Clicked += BlueTag_Clicked;
            BlueBelt.Clicked += BlueBelt_Clicked;
            RedTag.Clicked += RedTag_Clicked;
            RedBelt.Clicked += RedBelt_Clicked;
            BlackTag.Clicked += BlackTag_Clicked;
            var gradeList = Enum.GetNames(typeof(AllGrades)).Select(b => b.SplitCamelCase()).ToList();

            ChangeGrade.ItemsSource = gradeList;
            ChangeGrade.SelectedItem = gradeList.Find(b => b.Equals(Grade.Text));
        }

        async void BlackTag_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(YellowTagWords));
        }

        async void RedBelt_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(YellowTagWords));
        }

        async void RedTag_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(YellowTagWords));
        }

        async void BlueBelt_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(YellowTagWords));
        }

        async void BlueTag_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(YellowTagWords));
        }

        async void GreenBelt_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GreenBeltWords));
        }

        async void GreenTag_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(GreenTagWords));
        }

        async void YellowBelt_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(YellowBeltWords));
        }

        async void WhiteBelt_Clicked(object sender, System.EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(WhiteBeltWords));
        }

        async void YellowTag_Clicked(object sender, System.EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(YellowTagWords));
        }

        async void CheckBelt(object sender, EventArgs e)
        {
            await Task.Delay(500);
            Debug.WriteLine(Name.Text);
            var belt = Grade.Text;
            switch (belt)
            {
                case "White Belt":
                    YellowBelt.IsEnabled = false;
                    GreenTag.IsEnabled = false;
                    GreenBelt.IsEnabled = false;
                    BlueTag.IsEnabled = false;
                    BlueBelt.IsEnabled = false;
                    RedTag.IsEnabled = false;
                    RedBelt.IsEnabled = false;
                    BlackTag.IsEnabled = false;
                    break;

                case "Yellow Tag":
                    GreenTag.IsEnabled = false;
                    GreenBelt.IsEnabled = false;
                    BlueTag.IsEnabled = false;
                    BlueBelt.IsEnabled = false;
                    RedTag.IsEnabled = false;
                    RedBelt.IsEnabled = false;
                    BlackTag.IsEnabled = false;
                    break;

                case "Yellow Belt":
                    GreenBelt.IsEnabled = false;
                    BlueTag.IsEnabled = false;
                    BlueBelt.IsEnabled = false;
                    RedTag.IsEnabled = false;
                    RedBelt.IsEnabled = false;
                    BlackTag.IsEnabled = false;
                    break;

                case "Green Tag":
                    BlueTag.IsEnabled = false;
                    BlueBelt.IsEnabled = false;
                    RedTag.IsEnabled = false;
                    RedBelt.IsEnabled = false;
                    BlackTag.IsEnabled = false;
                    break;

                case "Green Belt":
                    BlueTag.IsEnabled = false;
                    BlueBelt.IsEnabled = false;
                    RedTag.IsEnabled = false;
                    RedBelt.IsEnabled = false;
                    BlackTag.IsEnabled = false;
                    break;

                case "Blue Tag":
                    BlueBelt.IsEnabled = false;
                    RedTag.IsEnabled = false;
                    RedBelt.IsEnabled = false;
                    BlackTag.IsEnabled = false;
                    break;

                case "Blue Belt":
                    RedTag.IsEnabled = false;
                    RedBelt.IsEnabled = false;
                    BlackTag.IsEnabled = false;
                    break;

                case "Red Tag":
                    RedBelt.IsEnabled = false;
                    BlackTag.IsEnabled = false;
                    break;

                case "Red Belt":
                    BlackTag.IsEnabled = false;
                    break;

                case "Black Tag":
                    break;
            }
        }
    }
}