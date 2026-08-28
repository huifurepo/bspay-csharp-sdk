using System;
using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;
using Org.BouncyCastle.Utilities.Encoders;

namespace BasePaySdk
{
    /// <summary>
    /// SM2签名工具类，与Java端BouncyCastle SM2签名保持一致
    /// Java端使用 Signature.getInstance(GMObjectIdentifiers.sm2sign_with_sm3.toString(), BC_PROVIDER)
    /// 签名输出为Hex字符串，编码格式为DER
    /// </summary>
    public class Sm2Utils
    {
        /// <summary>
        /// 使用SM2私钥进行签名
        /// </summary>
        ///
        /// <param name="privateKey">SM2私钥（Base64编码，PKCS8格式）</param>
        /// <param name="data">待签名数据</param>
        ///
        /// <returns>签名值（Hex字符串）</returns>
        ///
        public static string sign(string privateKey, string data)
        {
            ECPrivateKeyParameters privateKeyParameters = ParsePrivateKey(privateKey);

            SM2Signer signer = new SM2Signer();
            ICipherParameters cipherParameters = new ParametersWithRandom(privateKeyParameters);
            signer.Init(true, cipherParameters);

            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            signer.BlockUpdate(dataBytes, 0, dataBytes.Length);

            byte[] signature = signer.GenerateSignature();
            return Hex.ToHexString(signature);
        }

        /// <summary>
        /// 使用SM2公钥进行验签
        /// </summary>
        ///
        /// <param name="publicKey">SM2公钥（Base64编码）</param>
        /// <param name="signature">签名值（Hex字符串）</param>
        /// <param name="data">签名原文</param>
        ///
        /// <returns>验签结果</returns>
        ///
        public static bool verfySign(string publicKey, string signature, string data)
        {
            ECPublicKeyParameters publicKeyParameters = ParsePublicKey(publicKey);

            SM2Signer signer = new SM2Signer();
            signer.Init(false, publicKeyParameters);

            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            signer.BlockUpdate(dataBytes, 0, dataBytes.Length);

            byte[] signatureBytes = Hex.Decode(signature);
            return signer.VerifySignature(signatureBytes);
        }

        /// <summary>
        /// 解析SM2私钥（PKCS8格式）
        /// </summary>
        private static ECPrivateKeyParameters ParsePrivateKey(string privateKey)
        {
            byte[] keyBytes = Convert.FromBase64String(privateKey);
            AsymmetricKeyParameter keyParameter = Org.BouncyCastle.Security.PrivateKeyFactory.CreateKey(keyBytes);
            return (ECPrivateKeyParameters)keyParameter;
        }

        /// <summary>
        /// 解析SM2公钥
        /// </summary>
        private static ECPublicKeyParameters ParsePublicKey(string publicKey)
        {
            byte[] keyBytes = Convert.FromBase64String(publicKey);
            AsymmetricKeyParameter keyParameter = Org.BouncyCastle.Security.PublicKeyFactory.CreateKey(keyBytes);
            return (ECPublicKeyParameters)keyParameter;
        }
    }
}
