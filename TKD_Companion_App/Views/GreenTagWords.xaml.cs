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
    public partial class GreenTagWords : ContentPage
    {
        public GreenTagWords()
        {
            InitializeComponent();

            BindingContext = new GreenTagWordsViewModel();

            Tenets.Text = "Courtesy (Ye Ui / 예의)\r\nIntegrity (Yom Chi / 염치)\r\nPerseverance (In Nae / 인내)\r\nSelf Control (Guk Gi / 극기)\r\nIndomitable Spirit (Baekjul Boolgool / 백절불굴)";
            GreenMeaning.Text = "Represents the plants growth as the Taekwon-Do skills begin to develop.";
            YellowMeaning.Text = "Represents the earth from which the plant sprouts and takes root as the Taekwon-Do foundation is being laid.";
            YellowBeltPattern.Text = "Do San: \r\nIs the pen name of the patriot Ahn Chang Ho (born 1876, died 1938). The 24 movements in the pattern represent his entire life which he devoted to furthering the education of Korea and its independence movement";
            YellowBeltStances.Text = "L-Stance: Nuinja Sogi\r\nWalking Stance: Gunnan Sogi\r\nSitting Stance: Annun Sogi";
            YellowBeltMovements.Text = "Straight Fingertip Thrust: Sun Sonkut Tulgi\r\nBackfist Side Strike: Dung Joomuk Yop Taerigi\r\nOuter Forearm Wedging Block: Pakat Palmok Haechyo Makgi";
            GreenTagHandParts.Text = "Backfist: Dung Joomuk\r\nFingertip: Sonkut";
            YellowBeltGeneral.Text = "Thrust: Tulgi\r\nOne Step Sparring: Ilbo Matsogi\r\nHead: Mori\r\nStraight: Sun";
        }
    }
}