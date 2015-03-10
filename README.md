# XXTEA for .NET

## Introduction

XXTEA is a fast and secure encryption algorithm. This is a XXTEA library for .NET.

It is different from the original XXTEA encryption algorithm. It encrypts and decrypts Byte[] instead of 32bit integer array, and the key is also the Byte[].

In addition to providing the API of Byte[] encryption and decryption, it also provides some methods to handle String and Base64 encode.

## Installation

```sh
git clone https://github.com/xxtea/xxtea-dotnet.git
```

## Usage

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
