using System;

using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio04
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScanningDemo : ContentPage
    {
        public ScanningDemo()
        {
            InitializeComponent();
            btnScan.Clicked += btnScan_Clicked;
        }

      

        private async void btnScan_Clicked(object sender, EventArgs e)
        {
            var scanner = DependencyService.Get<IQrScanningService>();
            var result = await scanner.ScanAsync();
            if (result != null)
            {
                txtBarcode.Text = result;
            }
        }
    }
}