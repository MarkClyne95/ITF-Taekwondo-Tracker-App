using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKD_Companion_App.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TKD_Companion_App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class YellowBeltWords : ContentPage
    {
        public YellowBeltWords()
        {
            InitializeComponent();

            BindingContext = new YellowBeltWordsViewModel();

            Tenets.Text = "Courtesy (Ye Ui / 예의)\r\nIntegrity (Yom Chi / 염치)\r\nPerseverance (In Nae / 인내)\r\nSelf Control (Guk Gi / 극기)\r\nIndomitable Spirit (Baekjul Boolgool / 백절불굴)";
            GreenMeaning.Text = "Represents the plants growth as the Taekwon-Do skills begin to develop.";
            YellowMeaning.Text = "Represents the earth from which the plant sprouts and takes root as the Taekwon-Do foundation is being laid.";
            YellowBeltPattern.Text = "Dan Gun: \r\nIs named after Holy Dan Gun, the legendary founder of Korea in the year 2333 B.C. The pattern has 21 moves.";
            YellowBeltStances.Text = "L-Stance: Nuinja Sogi\r\nWalking Stance: Gunnan Sogi";
            YellowBeltMovements.Text = "Rising Block: Chookyo Makgi\r\nTurning Kick: Dollyo Chagi\r\nBack Piercing Kick: Dwit Chat Jirugi\r\nKnifehand Side Strike: Sonkal Yop Taerigi\r\nTwin Forearm Block: Sang Palmok Makgi\r\nHigh Forefist Punch: Nopunde Ap Joomuk Jirugi";
            YellowBeltGeneral.Text = "Strike: Taerigi\r\nThumb: Umji\r\nTwin: Sang\r\nThree Step Sparring: Sambo Matsogi";
        }
    }
}