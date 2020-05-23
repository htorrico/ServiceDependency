
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio04
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Item1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new TextToSpeechDemo());

            };

            Item2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new BatteryDemo());
            };
            Item3.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ScanningDemo());
            };
        }
    }
}
