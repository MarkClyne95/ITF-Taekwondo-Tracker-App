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
    public partial class YellowTagWords : ContentPage
    {
        public YellowTagWords()
        {
            InitializeComponent();

            BindingContext = new YellowBeltWordsViewModel();

            Tenets.Text = "Courtesy (Ye Ui / 예의)\r\nIntegrity (Yom Chi / 염치)\r\nPerseverance (In Nae / 인내)\r\nSelf Control (Guk Gi / 극기)\r\nIndomitable Spirit (Baekjul Boolgool / 백절불굴)";
            WhiteMeaning.Text = "Signifies innocence, as in that of the beginner, a student who has no previous knowledge of Taekwon-Do.";
            YellowMeaning.Text = "Represents the earth from which the plant sprouts and takes root as the Taekwon-Do foundation is being laid.";
            YellowTagPattern.Text = "Chon Ji: \r\nMeans literally Heaven and Earth. In the orient it is interpreted as the creation of the world or the beginning of human history, and is therefore the initial pattern practiced by the beginner. The pattern has nineteen moves and consists of two similar parts. One to represent Heaven and the other Earth.";
            YellowTagStances.Text = "L-Stance: Nuinja Sogi\r\nWalking Stance: Gunnan Sogi";
            YellowTagMovements.Text = "Front Snap Kick: Ap Cha Busigi\r\nSide Piercing Kick: Yop Cha Jirugi\r\nObverse Punch: Baro Jirugi\r\nReverse Punch: Bandae Jirugi\r\nDouble Punch: Dool Jirugi\r\nInner Forearm Block: An Palmok Makgi\r\nOuter Forearm Block: Pakat Palmok Makgi";
            YellowTagHeights.Text = "High: Nopunde\r\nMiddle: Kaunde\r\nLow: Najunde";
            YellowTagGeneral.Text = "Ball of Foot: Ap Goomchi\r\nFoot Sword: Balkal\r\nBlock: Makgi\r\nStance: Sogi\r\nKick: Chagi\r\nPattern: Tul";
        }
    }
}