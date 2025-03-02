using System.Text;
using System.Security.Cryptography;

namespace Security.Methods;
// Methods to encrypt/decrypt with AES (Advanced Encryption Standard)
public class AES
{
    // Encrypt with AES (Advanced Encryption Standard)
    public static string AESEncrypt(string key, string iv, string Input)
    {
        using Aes AESAlg = Aes.Create();
        AESAlg.Key = Encoding.UTF8.GetBytes(key);
        AESAlg.IV = Encoding.UTF8.GetBytes(iv);
        ICryptoTransform Encryptor = AESAlg.CreateEncryptor(AESAlg.Key, AESAlg.IV);
        using MemoryStream MSe = new();
        using CryptoStream CSe = new(MSe, Encryptor, CryptoStreamMode.Write);
        using (StreamWriter SWe = new(CSe))
        {
            SWe.Write(Input);
        }
        return Convert.ToBase64String(MSe.ToArray());
    }
    // Decrypt with AES (Advanced Encryption Standard)
    public static string AESDecrypt(string key, string iv, string Input)
    {
        using Aes AESAlg = Aes.Create();
        AESAlg.Key = Encoding.UTF8.GetBytes(key);
        AESAlg.IV = Encoding.UTF8.GetBytes(iv);
        ICryptoTransform Decryptor = AESAlg.CreateDecryptor(AESAlg.Key, AESAlg.IV);
        using MemoryStream MSd = new(Convert.FromBase64String(Input));
        using CryptoStream CSd = new(MSd, Decryptor, CryptoStreamMode.Read);
        using StreamReader SRd = new(CSd);
        return SRd.ReadToEnd();
    }
}
