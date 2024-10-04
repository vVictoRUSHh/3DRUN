using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
public class AESCrypto
{
    private readonly byte[] Key;
    private readonly byte[] IV;

    public AESCrypto(string key)
    {
        Key = Encoding.UTF8.GetBytes(key.PadRight(32).Substring(0, 32));
        IV = new byte[16];
        Array.Copy(Key, IV, IV.Length);
    }

    public string Encrypt(string plainText)
    {
        using (Aes aes = Aes.Create())
        {
            aes.Key = Key;
            aes.IV = IV;

            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    using (StreamWriter sw = new StreamWriter(cs))
                    {
                        sw.Write(plainText);
                    }
                }
                return Convert.ToBase64String(ms.ToArray());
            }
        }
    }

    public string Decrypt(string cipherText)
    {
        using (Aes aes = Aes.Create())
        {
            aes.Key = Key;
            aes.IV = IV;

            using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(cipherText)))
            {
                using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Read))
                {
                    using (StreamReader sr = new StreamReader(cs))
                    {
                        return sr.ReadToEnd();
                    }
                }
            }
        }
    }
}
