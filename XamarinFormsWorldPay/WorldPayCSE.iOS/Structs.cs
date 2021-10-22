using System;
using ObjCRuntime;

namespace NativeLibrary
{

    [Native]
    public enum WPErrorCode : ulong
    {
        BufferAlloc = 9000,
        AESEncrypt,
        AESCTXAlloc,
        RSAInvalidPublicKey,
        RSAEncrypt,
        RandKeyGenError,
        InvalidCardData
    }



    [Native]
    public enum WPCardValidatorError : ulong
    {
        None = 0,
        EmptyCardNumber = 101,
        InvalidCardNumber = 102,
        InvalidCardNumberLuhn = 103,
        InvalidSecurityCode = 201,
        EmptyExpiryMonth = 301,
        InvalidExpiryMonthValue = 302,
        InvalidExpiryMonthRange = 303,
        EmptyExpiryYear = 304,
        InvalidExpiryYearValue = 305,
        ExpiryYearFromPast = 306,
        EmpyCardholderName = 401,
        CardholderNameTooLong = 402
    }
}

