using System;
using System.Diagnostics;
using Xxtea;

namespace Example {
    class MainClass {
        public static void Main (string[] args) {
            String str = "Hello World! 你好，中国！";
            String key = "1234567890";
            String encrypt_data = XXTEA.EncryptToBase64String(str, key);
            Console.WriteLine(encrypt_data);
            Debug.Assert("QncB1C0rHQoZ1eRiPM4dsZtRi9pNrp7sqvX76cFXvrrIHXL6" == encrypt_data);
            String decrypt_data = XXTEA.DecryptBase64StringToString(encrypt_data, key);
            Debug.Assert(str == decrypt_data);
        }
    }
}
