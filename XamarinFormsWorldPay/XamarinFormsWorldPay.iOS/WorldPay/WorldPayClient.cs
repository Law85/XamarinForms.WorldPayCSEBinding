using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIKit;
using WorldpayCSE;
using Xamarin.Forms;
using XamarinFormsWorldPay.iOS.WorldPay;
using XamarinFormsWorldPay.WorldPay;

[assembly: Dependency(typeof(WorldPayClient))]
namespace XamarinFormsWorldPay.iOS.WorldPay
{
    public class WorldPayClient : IWorldPayClient
    {
        public Task<string> EncryptCardData(string publicKey, object cardObject)
        {
            throw new NotImplementedException();
        }
        /// IMPORTANT - DUE TO A BUG IN VS YOU CANT HAVE THE IOS BINDING Library in the same sln as the rest of the solution and get . You  therefore will need to target the dll in the obj of the WorldPayCSE.iOS and then unload the proj if you like having intelisense :S
        /// Propose creating our own cardinal nuget feed
        /// see https://social.msdn.microsoft.com/Forums/en-US/33793c23-fe3c-4316-9deb-1b99b58d3a04/ios-objc-binding-cant-see-namespace?forum=xamarinios 
        public async Task<string> EncryptTestCardData()
        {
            var worldpayCSE = new WorldpayCSE.WorldpayCSE();
            var NSKeyError = new NSError();


            worldpayCSE.SetPublicKey(new NSString("1#10001#bf49edcaba456c6357e4ace484c3fba212543e78bf" +
            "72a8c2238caaa1c7ed20262956caa61d74840598d9b0707bc8" +
            "2e66f18c8b369c77ae6be0429c93323bb7511fc73d9c7f6988" +
            "72a8384370cd77c7516caa25a195d48701e3e0462d61200983" +
            "ba26cc4a20bb059d5beda09270ea6dcf15dd92084c4d5867b6" +
            "0986151717a8022e4054462ee74ab8533dda77cee227a49fda" +
            "f58eaeb95df90cb8c05ee81f58bec95339b6262633aef216f3" +
            "ae503e8be0650350c48859eef406e63d4399994b147e45aaa1" +
            "4cf9936ac6fdd7d4ec5e66b527d041750ba63a8296b3e6e774" +
            "a02ee6025c6ee66ef54c3688e4844be8951a8435e6b6e8d676" +
            "3d9ee5f16521577e159d"), out NSKeyError);

            var ErrorKey = NSKeyError;

            WPCardData wpCardData = new WPCardData()
            {
                CardNumber = new NSString("4444333322221111"),
                Cvc = new NSString("123"),
                ExpiryMonth = new NSString("11"),
                ExpiryYear = new NSString("2023"),
                CardHolderName = new NSString("John Doe")

            };



            try
            {
                //var testcarddata = WorldpayCSE.WorldpayCSE.Validate(wpCardData);
                NSError NSEncryptError;
                var encyptedData = worldpayCSE.Encrypt(wpCardData, out NSEncryptError);
      
                var ErrorEncrypt = NSEncryptError;

                return ErrorEncrypt != null ? ErrorEncrypt.ToString() : encyptedData;
            }

            catch (Exception e)
            {
                return e.Message;
            }

      
        }
    }
    }
