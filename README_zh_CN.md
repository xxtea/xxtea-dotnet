# XXTEA 加密算法的 .NET 实现

## 简介

XXTEA 是一个快速安全的加密算法。本项目是 XXTEA 加密算法的 .NET 实现。

它不同于原始的 XXTEA 加密算法。它是针对 Byte[] 类型数据进行加密的，而不是针对 32 位整型数组。同样，密钥也是 Byte[]。

为了用户使用方便，除了提供对 Byte[] 进行加解密的 API 之外，还提供了一些辅助方法来处理字符串和 Base64 编码。

## 安装

```sh
git clone https://github.com/xxtea/xxtea-dotnet.git
```

## 使用

```csharp
using System;
using System.Diagnostics;
using Xxtea;

namespace Example {
    class MainClass {
        public static void Main (string[] args) {
            String str = "Hello World! 你好，中国！";
            String key = "1234567890";
            Byte[] encrypt_data = XXTEA.Encrypt(str, key);
            String decrypt_data = XXTEA.DecryptToString(encrypt_data, key);
            Debug.Assert(str == decrypt_data);
        }
    }
}
```
