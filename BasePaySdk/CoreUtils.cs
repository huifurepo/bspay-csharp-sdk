using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Reflection;
using System.Security.Policy;
using System.Text.RegularExpressions;
using BasePaySdk.Request;

namespace BasePaySdk
{
    public class CoreUtils
    {

        
        public static string GetMD5Hash(string str)
        {
            //就是比string往后一直加要好的优化容器
            StringBuilder sb = new StringBuilder();
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                //将输入字符串转换为字节数组并计算哈希。
                byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(str));

                int length = data.Length;
                for (int i = 0; i < length; i++)
                    sb.Append(data[i].ToString("X2"));

            }
            return sb.ToString();
        }

        public static byte[] File2Bytes(string FilePath)
        {
            if (!System.IO.File.Exists(FilePath))
            {
                return new byte[0];
            }

            FileStream fs = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            byte[] buff = new byte[fs.Length];

            fs.Read(buff, 0, Convert.ToInt32(fs.Length));
            fs.Close();

            return buff;
        }

        public static string getOrignalString(Dictionary<string, object> dict) {

            Dictionary<string, object> params_SortedByKey = dict.OrderBy(p => p.Key).ToDictionary(p => p.Key, o => o.Value);
            StringBuilder orinalStr = new StringBuilder("");

            foreach (KeyValuePair<string, object> item in params_SortedByKey)
            {
                orinalStr.Append(item.Key)
                    .Append("=")
                    .Append(item.Value)
                    .Append("&");

            }
            if (orinalStr.Equals(""))
            {
                return "";
            }
            else {
                orinalStr.Remove(orinalStr.Length - 1, 1);
            }
            return orinalStr.ToString();   
        }
        public static void Log(string message)
        {
            if (BasePay.debug) {
                Console.WriteLine(message);
            }
        }

        public static Dictionary<string, Object> ObjToMap(BaseRequest obj)
        {
            Dictionary<string, Object> map = new Dictionary<string, Object>();
            FieldInfo[] list = obj.GetType().GetFields(BindingFlags.IgnoreCase | BindingFlags.DeclaredOnly| BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            foreach (FieldInfo p in list)
            {
                if (p.FieldType == typeof(string))
                {
                    //Console.WriteLine("键：" + p.Name + ",值：" + p.GetValue(zone, null));
                    map.Add(ToUnderLine(p.Name), p.GetValue(obj).ToString());
                }
                
            }
            return map;
        }

        public static string ToUnderLine(string camelName)
        {
            return Regex.Replace(camelName, "([A-Z])", "_$1").ToLower().TrimStart('_');
        }
    }

}
