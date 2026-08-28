using System;


namespace BasePaySdk
{
    /// <summary>
    /// 商户配置
    /// </summary>
    public class MerConfig
    {

        public MerConfig()
        {
            
        }
        //商户rsa 私钥
        public string RsaPrivateKey;

        // 商户公钥
        public String RsaPublicKey;

        // 分配的系统号
        public string SysId;

        // 分配的产品号
        public string ProductId;

        //签名类型，默认值RSA，可选SM2、RSA
        public String SignType;

        //商户私钥，用于商户给交易信息签名

        public String Sm2PrivateKey;

        // 公钥，商户用公钥对汇付返回的信息进行验签

        public String Sm2PublicKey;

    }

}

