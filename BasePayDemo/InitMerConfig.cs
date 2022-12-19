using System;
using System.Collections.Generic;
using BasePaySdk;

namespace BasePayDemo
{
    public class InitMerConfig
    {
        public static void init (){
            // 是否调试模式，默认为false
            BasePay.debug = true;
            // 是否生产模式，默认为true
            BasePay.prodMode = true;

            // 单套商户配置
            // 默认为单商户配置，配置key默认为default，上送报文时无需指定配置key
            MerConfig config = new MerConfig();
            config.ProductId = DemoConstants.DEMO_PRODUCT_ID;
            config.SysId = DemoConstants.DEMO_SYS_ID;
            config.RsaPrivateKey = DemoConstants.RSA_PRIVATE_KEY;
            config.RsaPublicKey = DemoConstants.RSA_PUBLIC_KEY;
            BasePay.initWithMerConfig(config);

            // 下面示例为多套商户配置的情形
            // 如商户因特殊需要，申请多套配置，则需自行做好配置管理，上送报文时需明确指定使用哪套商户配置
            Dictionary<string, MerConfig> configs = new Dictionary<string, MerConfig>();
            MerConfig config1 = new MerConfig();
            config1.ProductId = DemoConstants.DEMO_PRODUCT_ID;
            config1.SysId = DemoConstants.DEMO_SYS_ID;
            config1.RsaPrivateKey = DemoConstants.RSA_PRIVATE_KEY;
            config1.RsaPublicKey = DemoConstants.RSA_PUBLIC_KEY;
            // 多套配置的key自行指定，保持唯一即可
            configs.Add("merchantKey1", config1);

            MerConfig config2 = new MerConfig();
            config2.ProductId = DemoConstants.DEMO_PRODUCT_ID;
            config2.SysId = DemoConstants.DEMO_SYS_ID;
            config2.RsaPrivateKey = DemoConstants.RSA_PRIVATE_KEY;
            config2.RsaPublicKey = DemoConstants.RSA_PUBLIC_KEY;
            // 多套配置的key自行指定，保持唯一即可
            configs.Add("merchantKey2", config2);
            BasePay.initWithMerConfigs(configs);
        }
    }
}
