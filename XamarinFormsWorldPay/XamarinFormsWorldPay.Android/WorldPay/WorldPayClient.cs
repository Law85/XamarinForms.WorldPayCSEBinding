using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Worldpay.Cse;
using Com.Worldpay.Cse.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinFormsWorldPay.Droid.WorldPay;
using XamarinFormsWorldPay.WorldPay;

[assembly: Dependency(typeof(WorldPayClient))]
namespace XamarinFormsWorldPay.Droid.WorldPay
{
    public class WorldPayClient : IWorldPayClient
    {
        public Task<string> EncryptCardData(string publicKey, object cardObject)
        {
            throw new NotImplementedException();
        }
       
        public async Task<string> EncryptTestCardData()
        {
            TaskCompletionSource<string> tcs = new TaskCompletionSource<string>();
            var worldpayCSE = new Com.Worldpay.Cse.WorldpayCSE();
            worldpayCSE.SetPublicKey("1#10001#bf49edcaba456c6357e4ace484c3fba212543e78bf" +
            "72a8c2238caaa1c7ed20262956caa61d74840598d9b0707bc8" +
            "2e66f18c8b369c77ae6be0429c93323bb7511fc73d9c7f6988" +
            "72a8384370cd77c7516caa25a195d48701e3e0462d61200983" +
            "ba26cc4a20bb059d5beda09270ea6dcf15dd92084c4d5867b6" +
            "0986151717a8022e4054462ee74ab8533dda77cee227a49fda" +
            "f58eaeb95df90cb8c05ee81f58bec95339b6262633aef216f3" +
            "ae503e8be0650350c48859eef406e63d4399994b147e45aaa1" +
            "4cf9936ac6fdd7d4ec5e66b527d041750ba63a8296b3e6e774" +
            "a02ee6025c6ee66ef54c3688e4844be8951a8435e6b6e8d676" +
            "3d9ee5f16521577e159d");

            WPCardData wpCardData = new WPCardData()
            {
                CardNumber = "4444333322221111",
                Cvc = "123",
                ExpiryMonth = "11",
                ExpiryYear = "2023",
                CardHolderName = "John Doe"

            };
            try
            {
                var encypteddata = worldpayCSE.Encrypt(wpCardData);
                tcs.SetResult(encypteddata);
                return await tcs.Task;
            }
            catch (WPCSEInvalidCardData e)
            {
                var code = e.ErrorCodes.FirstOrDefault();
                return string.Empty;
            }
            catch (WPCSEException e)
            {
                return string.Empty;
            }

        }
    }
}