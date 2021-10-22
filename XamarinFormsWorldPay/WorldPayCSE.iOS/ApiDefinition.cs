using System;

using ObjCRuntime;
using Foundation;
using UIKit;

namespace WorldpayCSE
{
    // @interface WPPublicKey : NSObject
    [BaseType(typeof(NSObject))]
    interface WPPublicKey
    {
        // @property (nonatomic, strong) NSString * sequenceId;
        [Export("sequenceId", ArgumentSemantic.Strong)]
        string SequenceId { get; set; }



        // @property (nonatomic, strong) NSString * exponent;
        [Export("exponent", ArgumentSemantic.Strong)]
        string Exponent { get; set; }



        // @property (nonatomic, strong) NSString * modulus;
        [Export("modulus", ArgumentSemantic.Strong)]
        string Modulus { get; set; }



        // +(id)parseKey:(NSString *)publicKey error:(NSError **)error;
        [Static]
        [Export("parseKey:error:")]
        NSObject ParseKey(string publicKey, out NSError error);
    }



    // @interface WPCardData : NSObject
    [BaseType(typeof(NSObject))]
    interface WPCardData
    {
        // @property (nonatomic, strong) NSString * cardNumber;
        [Export("cardNumber", ArgumentSemantic.Strong)]
        string CardNumber { get; set; }



        // @property (nonatomic, strong) NSString * cvc;
        [Export("cvc", ArgumentSemantic.Strong)]
        string Cvc { get; set; }



        // @property (nonatomic, strong) NSString * expiryMonth;
        [Export("expiryMonth", ArgumentSemantic.Strong)]
        string ExpiryMonth { get; set; }



        // @property (nonatomic, strong) NSString * expiryYear;
        [Export("expiryYear", ArgumentSemantic.Strong)]
        string ExpiryYear { get; set; }



        // @property (nonatomic, strong) NSString * cardHolderName;
        [Export("cardHolderName", ArgumentSemantic.Strong)]
        string CardHolderName { get; set; }



        // -(NSString *)jsonString;
        [Export("jsonString")]
        string JsonString { get; }
    }



    //[Static]
    //partial interface Constants
    //{
    //    // extern NSString *const kWPJWEHeaderLibraryVersionValue;
    //    [Field("kWPJWEHeaderLibraryVersionValue", "__Internal")]
    //    NSString kWPJWEHeaderLibraryVersionValue { get; }



    //    // extern NSString *const kWPJWEHeaderApiVersionValue;
    //    [Field("kWPJWEHeaderApiVersionValue", "__Internal")]
    //    NSString kWPJWEHeaderApiVersionValue { get; }



    //    // extern NSString *const kWPJWEHeaderChannelValue;
    //    [Field("kWPJWEHeaderChannelValue", "__Internal")]
    //    NSString kWPJWEHeaderChannelValue { get; }



    //    // extern NSString *const kWPErrorDomain;
    //    [Field("kWPErrorDomain", "__Internal")]
    //    NSString kWPErrorDomain { get; }



    //    // extern NSString *const kWPErrorDetailsKey;
    //    [Field("kWPErrorDetailsKey", "__Internal")]
    //    NSString kWPErrorDetailsKey { get; }
    //}



    // @interface WorldpayCSE : NSObject
    [BaseType(typeof(NSObject))]
    interface WorldpayCSE
    {
        // -(BOOL)setPublicKey:(NSString *)publicKey error:(NSError **)error;
        [Export("setPublicKey:error:")]
        bool SetPublicKey(string publicKey, out NSError error);



        // -(void)setPublicKey:(WPPublicKey *)publicKey;
        [Export("setPublicKey:")]
        void SetPublicKey(WPPublicKey publicKey);



        // -(WPPublicKey *)getPublicKey;
        [Export("getPublicKey")]
        WPPublicKey PublicKey { get; }



        // -(NSString *)encrypt:(WPCardData *)cardData error:(NSError **)error;
        [Export("encrypt:error:")]
        string Encrypt(WPCardData cardData, out NSError error);



        // +(NSSet *)validate:(WPCardData *)data;
        [Static]
        [Export("validate:")]
        NSSet Validate(WPCardData data);
    }
}

