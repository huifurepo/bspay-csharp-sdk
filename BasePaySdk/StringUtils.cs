using System;
using System.Collections.Generic;

namespace BasePaySdk
{
    public class StringUtils
    {
        public static string tryGetNotNullValue(Dictionary<string, object> dict, string key) {
            object value = null;
            dict.TryGetValue(key, out value);
            if (String.IsNullOrWhiteSpace((string)value))
            {
                throw new Exception(value + " cannot be empty");
            }
            return (string)value;

        }

    }
}
