# C# SDK 简介
    为了提高客户接入的便捷性，本系统提供 SDK 方式接入，使用本 SDK 将极大的简化开发者的工作，开发者将无需考虑通信、签名、验签等，只需要关注业务参数的输入。

## SDK 项目结构说明
- BasePaySdk -- SDK核心包, 包含通信, 加解签, 接口参数对象等
- Request -- 接口请求类, 包含接口所有必填字段

## SDK 接入说明 
以下两种方式任选其一
1. 直接在项目.csproj文件中引用(version 版本建议使用当前最新版)
```
    <ItemGroup>
      <PackageReference Include="DG-CSHARP-SDK" Version="x.x.x" />
    </ItemGroup>
```
2. 直接下载源码文件, 将BasePaySdk(SDK核心包)源码放入项目中


## SDK 使用说明
    可参考项目源码中demo的使用方式[源码地址](https://github.com/huifurepo/bspay-csharp-sdk)
    接口命名直接根据接口URL来命名, 方便用户使用, 需要使用某接口时, 可直接使用接口中文名, 或接口URL(驼峰格式)进行搜索, 找到对应的request, demo等

1. 配置初始化
- 初始化为全局配置(多商户模式下, 可初始化多份, 参考demo中方法)
```
    InitMerConfig.init();
```

2. 组装请求参数
- 为了接口使用更加方便, 我们将参数粗分为必填/非必填, 必填直接放在类中, 非必填放在extendInfos字段中
```
    // 2.组装请求参数
    V2MerchantBasicdataQueryRequest request = new V2MerchantBasicdataQueryRequest();
    // 请求流水号
    request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
    // 请求日期
    request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
    // 汇付客户Id
    request.setHuifuId("6666000108854952");

    // 设置非必填字段
    Dictionary<string, object> extendInfoMap = getExtendInfos();
    request.setExtendInfo(extendInfoMap);
```

3. 发起API调用
```
    // 3. 发起API调用
    Dictionary<string, Object> result = null;
    result = BasePayClient.postRequest(request, null);
```