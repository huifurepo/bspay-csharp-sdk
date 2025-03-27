using System;


namespace BasePayDemo
{
    class Program
    {
         static void Main(string[] args)
        {
            // 聚合扫码类交易实例
            // TransDemo.TransTest();

            //商户分期配置查询测试
            //MerchantDemo.testQueryFqFee();
            //上传图片
            //UploadDemo.testUpload();

            V2InvoiceOpenRequestDemo.V2InvoiceOpenRequestDemoTest();

            Console.ReadLine();
        }
    }
}
