﻿using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;  
using Android.App;  
using Android.Content;  
using Android.OS;  
using Android.Runtime;  
using Android.Views;  
using Android.Widget;  
using Ejercicio04;  
using ZXing.Mobile;  
using Xamarin.Forms;
using Android.Nfc.Tech;

[assembly: Dependency(typeof(Ejercicio04.Droid.QrScanningService))]
namespace Ejercicio04.Droid
{
    public class QrScanningService : IQrScanningService
    {
        public async Task<string> ScanAsync()
        {
            var optionsDefault = new MobileBarcodeScanningOptions();
            var optionsCustom = new MobileBarcodeScanningOptions();

            var scanner = new MobileBarcodeScanner()
            {
                TopText = "Scan the QR Code",
                BottomText = "Please Wait",
            };

            var scanResult = await scanner.Scan(optionsCustom);
            return scanResult.Text;
        }
    }
}