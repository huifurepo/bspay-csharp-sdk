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
        

    }

}

