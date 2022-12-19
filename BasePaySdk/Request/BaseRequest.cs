using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using BasePaySdk;

namespace BasePaySdk.Request
{
    public abstract class BaseRequest
    {

        /**
     * 其他拓展信息
     */
        protected Dictionary<string, Object> extendInfos = new Dictionary<string, Object>();

        public Dictionary<string, Object> getExtendInfos()
        {
            return extendInfos;
        }

        /**
         * 新增拓展参数
         *
         * @return
         */
        public void setExtendInfo(Dictionary<string, Object> extendInfos)
        {
            foreach (var ext in extendInfos)
            {
                this.extendInfos.Add(ext.Key, ext.Value);
            }

        }

        /**
         * 新增拓展参数
         *
         * @param key
         * @param value
         * @return
         */
        public void addExtendInfo(String key, Object value)
        {
            this.extendInfos.Add(key, value);
        }

        public BaseRequest()
        {
        }

        /**
         * functionCode对应接口url
         *
         * @return
         */
        public abstract string getFunctionCode();
    }
}