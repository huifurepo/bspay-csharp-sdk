using System;
using System.Collections.Generic;

namespace BasePaySdk
{
    public class BasePay{
        // 是否调试模式
        public static bool debug = false;
        // 是否生产模式
        public static bool prodMode = true;
        // sdk版本号
        public const string sdk_version = "1.0.21";
        // 接口生产基础地址
        public const string BASE_URL = "https://api.huifu.com";
        // 接口测试基础地址
        public const string BASE_URL_MOCK = "https://spin-test.cloudpnr.com";
        // 汇付默认公钥(未配置公钥时使用)
        public const string HUIFU_DEFAULT_PUBLIC_KEY = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAtEqXg6GQ5uQJdjFJC31FW/tvNNvNNFGGo2TH2+Lu2MCejINLcydesLr7MzvkcYybedh9nFv3xq71HdLj2joSE7df/weSh0o8HXHJzNTyHTEGhkIAtu48cbNZKL64fZlo6+EzqHhBI2wfr0Jx3Gj7UTkPn4tJ0T0j7u6NtQ2tC8TBGxp/uVhScvTvqHXWlnwLPXmV+58lj5KK5HPvD8qmYIZQUtaJ1S2Urlt+iQ24yRYpSdcF19aVp/fB5u9lGIszhu051EKgrjvubZ8r/XCC0Ku+Ek3zFoH+3QGd3yL6XGunXYrnwPAam8hqdimzHzgnK7EEFrEc0RKxi1s9ZFDzEwIDAQAB";
        // 商户配置信息表
        private static Dictionary<string, MerConfig> merchantConfigs = new Dictionary<string, MerConfig>();

        // 初始化默认商户配置
        public static void initWithMerConfig(MerConfig config) {
            if (null == merchantConfigs)
            {
                merchantConfigs = new Dictionary<string, MerConfig>();
            }
            if (null != config )
            {
                if (!merchantConfigs.ContainsKey("default")) 
                {
                    merchantConfigs.Add("default", config);
                }
            }
            else {
                throw new Exception("configs cannot be null");
            }
        }

        // 多套商户配置初始化
        public static void initWithMerConfigs(Dictionary<string, MerConfig> configs)
        {
            if (null == merchantConfigs)
            {
                merchantConfigs = new Dictionary<string, MerConfig>();
            }
            if (null != configs)
            {
                foreach(KeyValuePair<string, MerConfig> item in configs)

                {
                    merchantConfigs.Add(item.Key, item.Value);
                }            
            }
            else
            {
                throw new Exception("configs cannot be null");
            }
            
        }

        // 跟据配置名获取商户配置信息
        public static MerConfig fetchConfig(string merchantKey)
        {

            if (string.IsNullOrEmpty(merchantKey))
            {

                merchantKey = "default";
            }

            if (null == merchantConfigs)
            {
                throw new Exception("Please config merchant config info at first");
            }

            MerConfig config = null;
            merchantConfigs.TryGetValue(merchantKey, out config);
            if (null == config)
            {
                throw new Exception("config Info for merchantkey-" + merchantKey + " is not configed");
            }
            return config;
        }

        public static void cleanMerConfigs()
        {
            if (null != merchantConfigs)
            {
                merchantConfigs.Clear();
            }

        }
    }
}
