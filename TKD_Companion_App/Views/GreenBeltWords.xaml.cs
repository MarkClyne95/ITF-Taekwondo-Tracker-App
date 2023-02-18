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
    public partial class GreenBeltWords : ContentPage
    {
        public GreenBeltWords()
        {
            InitializeComponent();

            BindingContext = new GreenBeltWordsViewModel();

            Tenets.Text = "Courtesy (Ye Ui / 예의)\r\nIntegrity (Yom Chi / 염치)\r\nPerseverance (In Nae / 인내)\r\nSelf Control (Guk Gi / 극기)\r\nIndomitable Spirit (Baekjul Boolgool / 백절불굴)";
            YellowMeaning.Text = "Represents the plants growth as the Taekwon-Do skills begin to develop.";
            GreenMeaning.Text = "Represents the Heaven, towards which the plant matures into a towering tree as training in Taekwon-Do progresses.";
            YellowBeltPattern.Text = "Won Hyo: \r\nWas the noted monk who introduced Bhuddism into the Silla Dynasty in the year 686 A.D. \r\nThe pattern has 28 moves.\r\n";
            YellowBeltStances.Text = "Closed Ready Stance Type 'A': Moa Junbi Sogi 'A'\r\nFixed Stance: Gojung Sogi\r\nBending Ready Stance 'A': Guburyo Junbi Sogi 'A'\r\nL-Stance: Nuinja Sogi\r\nWalking Stance: Gunnan Sogi";
            YellowBeltMovements.Text = "Inner Forearm Circular Block: An Palmok Dollimyo Makgi\r\nForearm Guarding Block: Palmok Daebi Makgi\r\nKnifehand Inward Strike: Sonkal Anuro Taerigi";
            YellowBeltGeneral.Text = "Axe Kick/Downward Kick: Naeryo Chagi\r\nReverse Turning Kick: Bandae Dollyo Chagi\r\nHeel: Jeja\r\n1st-3rd Degree Assistant Instructor: Boosabum\r\n4th-6th Degree International Instructor: Sabum\r\n7th-8th Degree Master: Sahyun\r\n9th Degree Grand Master: Saseong\n\n When giving bowing commands, add 'nimgi' before the bow command e.g. \n Bowing to Masters Archer or Ridley at 8th Degree 'Chariot, Sahyun nimgi, kyong ye'";
        }
    }
}