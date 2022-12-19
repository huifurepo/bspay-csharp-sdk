

using System;


using System.Security.Cryptography;
using System.Text;

using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;


namespace BasePaySdk
{

    /// <summary>
    /// Rsa签名工具类
    /// </summary>
    public class RsaUtils
    {
        /// <summary>
        /// 使用指定私钥进行报文签名
        /// </summary>
        ///
        /// <param name="signaturePrivateKey">签名私钥</param>
        /// <param name="signatureData">待签名数据</param>
        /// <param name="hashAlgorithm">签名方法，默认SHA256</param>
        /// <param name="encoding">字符集，默认UTF-8</param>
        ///
        /// <returns>签名</returns>
        ///
        public static string sign(string signaturePrivateKey, string signatureData, string hashAlgorithm = "SHA256", string encoding = "UTF-8")
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            // var privateJavaKey = signaturePrivateKey;
            // var privateCSharpKey = RSAPrivateKeyJava2DotNet(privateJavaKey);
            // rsa.FromXmlString(privateCSharpKey);
            rsa.FromPrivateKeyJavaString(signaturePrivateKey);

            byte[] signatureBytes = rsa.SignData(Encoding.GetEncoding(encoding).GetBytes(signatureData), hashAlgorithm);
            return Convert.ToBase64String(signatureBytes);
            
        }

        private static string RSAPrivateKeyJava2DotNet(string privateKey)
        {
            byte[] keyInfoByte = Convert.FromBase64String(privateKey);
            RsaPrivateCrtKeyParameters privateKeyParam = (RsaPrivateCrtKeyParameters)PrivateKeyFactory.CreateKey(keyInfoByte);
            return string.Format("<RSAKeyValue><Modulus>{0}</Modulus><Exponent>{1}</Exponent><P>{2}</P><Q>{3}</Q><DP>{4}</DP><DQ>{5}</DQ><InverseQ>{6}</InverseQ><D>{7}</D></RSAKeyValue>",
            Convert.ToBase64String(privateKeyParam.Modulus.ToByteArrayUnsigned()),
            Convert.ToBase64String(privateKeyParam.PublicExponent.ToByteArrayUnsigned()),
            Convert.ToBase64String(privateKeyParam.P.ToByteArrayUnsigned()),
            Convert.ToBase64String(privateKeyParam.Q.ToByteArrayUnsigned()),
            Convert.ToBase64String(privateKeyParam.DP.ToByteArrayUnsigned()),
            Convert.ToBase64String(privateKeyParam.DQ.ToByteArrayUnsigned()),
            Convert.ToBase64String(privateKeyParam.QInv.ToByteArrayUnsigned()),
            Convert.ToBase64String(privateKeyParam.Exponent.ToByteArrayUnsigned()));
        }

        /// <summary>
        /// 使用指定公钥进行报文签名验证
        /// </summary>
        ///
        /// <param name="publicKey">公钥</param>
        /// <param name="signature">签名串</param>
        /// <param name="content">签名原文</param>
        /// <param name="hashAlgorithm">签名方法，默认SHA256</param>
        /// <param name="encoding">字符集，默认UTF-8</param>
        ///
        /// <returns>验签结果</returns>
        ///
        public static bool verfySign(string publicKey, string signature, string content, string hashAlgorithm = "SHA256", string encoding = "UTF-8")
        {

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            //导入公钥，准备验证签名
            rsa.FromPublicKeyJavaString(publicKey);
            //返回数据验证结果
            byte[] Data = Encoding.GetEncoding(encoding).GetBytes(content);
            byte[] rgbSignature = Convert.FromBase64String(signature);

            return rsa.VerifyData(Data, hashAlgorithm, rgbSignature);

        }
    }

    public static class RSAExtensions {
        public static void FromPublicKeyJavaString(this RSA rsa, string publicJavaKey)
        {
            RsaKeyParameters publicKeyParam = (RsaKeyParameters)PublicKeyFactory.CreateKey(Convert.FromBase64String(publicJavaKey));
            string xmlpublicKey = string.Format("<RSAKeyValue><Modulus>{0}</Modulus><Exponent>{1}</Exponent></RSAKeyValue>",
              Convert.ToBase64String(publicKeyParam.Modulus.ToByteArrayUnsigned()),
              Convert.ToBase64String(publicKeyParam.Exponent.ToByteArrayUnsigned()));

            rsa.FromXmlString(xmlpublicKey);
        }

        public static void FromPrivateKeyJavaString(this RSA rsa, string privateKey)
        {
            byte[] keyInfoByte = Convert.FromBase64String(privateKey);
            RsaPrivateCrtKeyParameters privateKeyParam = (RsaPrivateCrtKeyParameters)PrivateKeyFactory.CreateKey(keyInfoByte);
            string xmlPrivateKey = string.Format("<RSAKeyValue><Modulus>{0}</Modulus><Exponent>{1}</Exponent><P>{2}</P><Q>{3}</Q><DP>{4}</DP><DQ>{5}</DQ><InverseQ>{6}</InverseQ><D>{7}</D></RSAKeyValue>",
            Convert.ToBase64String(privateKeyParam.Modulus.ToByteArrayUnsigned()),
            Convert.ToBase64String(privateKeyParam.PublicExponent.ToByteArrayUnsigned()),
            Convert.ToBase64String(privateKeyParam.P.ToByteArrayUnsigned()),
            Convert.ToBase64String(privateKeyParam.Q.ToByteArrayUnsigned()),
            Convert.ToBase64String(privateKeyParam.DP.ToByteArrayUnsigned()),
            Convert.ToBase64String(privateKeyParam.DQ.ToByteArrayUnsigned()),
            Convert.ToBase64String(privateKeyParam.QInv.ToByteArrayUnsigned()),
            Convert.ToBase64String(privateKeyParam.Exponent.ToByteArrayUnsigned()));

            rsa.FromXmlString(xmlPrivateKey);
        }
    }
}

