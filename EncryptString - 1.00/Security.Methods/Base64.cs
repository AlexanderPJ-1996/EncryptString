using System.Text;

namespace Security.Methods;
// Methods to encrypt/decrypt with Base64
public class Base64
{
    // Encrypt with Base64
    public static string Base64Encrypt(string Input)
    {
        byte[] Bytes = Encoding.Unicode.GetBytes(Input);
        string Output = Convert.ToBase64String(Bytes);
        return Output;
    }
    // Decrypt with Base64
    public static string Base64Decrypt(string Input)
    {
        byte[] Bytes = Convert.FromBase64String(Input);
        string Output = Encoding.Unicode.GetString(Bytes);
        return Output;
    }
}
