# C# SDK ���
    Ϊ����߿ͻ�����ı���ԣ���ϵͳ�ṩ SDK ��ʽ���룬ʹ�ñ� SDK ������ļ򻯿����ߵĹ����������߽����迼��ͨ�š�ǩ������ǩ�ȣ�ֻ��Ҫ��עҵ����������롣

## SDK ��Ŀ�ṹ˵��
- BasePaySdk -- SDK���İ�, ����ͨ��, �ӽ�ǩ, �ӿڲ��������
- BasePayDemo -- �ӿڵ���/������ֵ��ʾdemo
- lib -- ����������

## SDK ����˵�� 
�������ַ�ʽ��ѡ��һ
1. ֱ������Ŀ.csproj�ļ�������(version �汾����ʹ�õ�ǰ���°�)
```
    <ItemGroup>
      <PackageReference Include="DG-CSHARP-SDK" Version="x.x.x" />
    </ItemGroup>
```
2. ֱ������Դ���ļ�, ��BasePaySdk(SDK���İ�)Դ�������Ŀ��


## SDK ʹ��˵��
    �ӿ�����ֱ�Ӹ��ݽӿ�URL������, �����û�ʹ��, ��Ҫʹ��ĳ�ӿ�ʱ, ��ֱ��ʹ�ýӿ�������, ��ӿ�URL(�շ��ʽ)��������, �ҵ���Ӧ��request, demo��

1. ���ó�ʼ��
- ��ʼ��Ϊȫ������(���̻�ģʽ��, �ɳ�ʼ�����, �ο�demo�з���)
```
    InitMerConfig.init();
```

2. ��װ�������
- Ϊ�˽ӿ�ʹ�ø��ӷ���, ���ǽ������ַ�Ϊ����/�Ǳ���, ����ֱ�ӷ�������, �Ǳ������extendInfos�ֶ���
```
    // 2.��װ�������
    V2MerchantBasicdataQueryRequest request = new V2MerchantBasicdataQueryRequest();
    // ������ˮ��
    request.setReqSeqId(DateTime.Now.ToString("yyy-MM-dd HH.mm.ss.fff"));
    // ��������
    request.setReqDate(DateTime.Now.ToString("yyyyMMdd"));
    // �㸶�ͻ�Id
    request.setHuifuId("6666000108854952");

    // ���÷Ǳ����ֶ�
    Dictionary<string, object> extendInfoMap = getExtendInfos();
    request.setExtendInfo(extendInfoMap);
```

3. ����API����
```
    // 3. ����API����
    Dictionary<string, Object> result = null;
    result = BasePayClient.postRequest(request, null);
```

