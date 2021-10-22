using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using XamarinFormsWorldPay.WorldPay;

namespace XamarinFormsWorldPay.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public ICommand TestEncryptionCommannd { get; }

        string _response = string.Empty;
        public string Response
        {
            get { return _response; }
            set { SetProperty(ref _response, value); }
        }
        public AboutViewModel()
        {
            Title = "About";
            TestEncryptionCommannd = new Command(() => { TestEncryption(); });
        }

        private async void TestEncryption()
        {
            Response = await DependencyService.Get<IWorldPayClient>().EncryptTestCardData();
        }
    }
}