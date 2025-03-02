using System.Text;
using System.Security.Cryptography;

namespace Security.Methods;
// Methods for encrypting with Secure Hash Algorithm: MD5, SHA-1, SHA-256, SHA-512
public class SHA
{
    // Hash Encryptor
    private static string HashEncrypt(string Input, HashAlgorithm Method)
    {
        byte[] TextBytes = Encoding.UTF8.GetBytes(Input);
        byte[] HashBytes = Method.ComputeHash(TextBytes);
        StringBuilder SB = new();
        foreach (byte B in HashBytes){ SB.Append(B.ToString("X2")); }
        return SB.ToString();
    }
    // encrypting with Secure Hash Algorithm: MD5
    public static string MD5Encrypt(string Input)
    {
        MD5 Md5 = MD5.Create();
        return HashEncrypt(Input, Md5);
    }
    // encrypting with Secure Hash Algorithm: SHA-160
    public static string SHA160Encrypt(string Input)
    {
        SHA1 Sha160 = SHA1.Create();
        return HashEncrypt(Input, Sha160);
    }
    // encrypting with Secure Hash Algorithm: SHA-256
    public static string SHA256Encrypt(string Input)
    {
        SHA256 sha256 = SHA256.Create();
        return HashEncrypt(Input, sha256);
    }
    // encrypting with Secure Hash Algorithm: SHA-512
    public static string SHA512Encrypt(string Input)
    {
        SHA512 sha512 = SHA512.Create();
        return HashEncrypt(Input, sha512);
    }
}
