using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace XamarinFormsWorldPay.WorldPay
{
    public interface IWorldPayClient
    {

        /// <summary>
        /// IMPORTANT, dlls are refrenced localy so you will need to rebuild both binding libaries first, then remove the dll reference from
        /// both IOS and Android projects and re add them.    
        /// ######For IOS please unload the cs proj of the binding solution due to bug detailed in IOS implementation of WorldPayClient
        /// </summary>
        /// <returns></returns>
        Task<string> EncryptTestCardData();
        Task<string> EncryptCardData(string publicKey, object cardObject);
    }
}
