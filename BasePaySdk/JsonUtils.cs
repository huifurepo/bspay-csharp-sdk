using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasePaySdk
{
    class JsonUtils
    {
        public static string sort4JsonString(string sourceJson)
        {

            var dic = JsonConvert.DeserializeObject<SortedDictionary<string, object>>(sourceJson);
            SortedDictionary<string, object> keyValues = new SortedDictionary<string, object>(dic);
            var result = keyValues.OrderBy(m => m.Key);//升序 把Key换成Value 就是对Value进行排序
                                                       //var result = keyValues.OrderByDescending(m => m.Key);//降序

            //简化为如下代码
            Dictionary<string, object> resultDic = result.ToDictionary(x => x.Key, x => x.Value);

            return JsonConvert.SerializeObject(resultDic);



        }
    }
}
