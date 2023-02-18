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
    public partial class WhiteBeltWords : ContentPage
    {
        public WhiteBeltWords()
        {
            InitializeComponent();

            BindingContext = new WhiteBeltWordsViewModel();

            Tenets.Text = "Courtesy (Ye Ui / 예의)\r\nIntegrity (Yom Chi / 염치)\r\nPerseverance (In Nae / 인내)\r\nSelf Control (Guk Gi / 극기)\r\nIndomitable Spirit (Baekjul Boolgool / 백절불굴)";
            WhiteMeaning.Text = "Signifies innocence, as in that of the beginner, a student who has no previous knowledge of Taekwon-Do.";
            WhiteStances.Text = "Attention Stance: Chariot Sogi(차렷 서기)\r\nParallel Stance: Narani Sogi(나란히 서기)\r\nSitting Stance: Annun Sogi(안눈 서기)\r\nWalking Stance: Gunnan Sogi(군난 서기)";
            WhiteBodyParts.Text = "Hand: Son(손)\r\nFoot: Bal(발)\r\nArm: Pal(팔)\r\nForefist: Ap Joomuk(앞 조먹)\r\nKnifehand: Sonkal(손칼)\r\nInner Forearm: An Palmok(안 팔묵)\r\nOuter Forearm: Pakat Palmok(바같 팔묵)";
            WhiteNumbers.Text = "One: Hana(하나)\r\nTwo: Dul(둘)\r\nThree: Set(셋)\r\nFour: Net(넷)\r\nFive: Dasot(다섯)\r\nSix:Yasot(여섯)\r\nSeven: Ilgop(일곱)\r\nEight: Yodul(여덟)\r\nNine: Ahop(아홉)\r\nTen: Yol(열)";
            WhiteCommands.Text = "Attention: Chariot(차렷)\r\nBow: Kyong Ye\r\nStart: Si Jak\r\nAt East: Swiyo\r\nDismiss: Hae San\r\nReady: Junbi\r\nStop: Guman\r\nTraining Suit: Dobok\r\nBelt: Ti";
        }
    }
}