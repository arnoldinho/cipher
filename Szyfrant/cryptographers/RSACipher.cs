using System;
using System.Security.Cryptography;
using System.Text;

namespace Szyfrant.cryptographers
{
    public class RSACipher : ICipher
    {
        public string Decrypt(string encrypted)
        {
            byte[] buffer = Convert.FromBase64String(encrypted);
            return DecryptRsa(buffer);
        }
        public string Encrypt(string unencrypted)
        {
            byte[] buffer = EncryptRsa(unencrypted);
            string result= Convert.ToBase64String(buffer);
            return result;
        }
        public static byte[] EncryptRsa(string input)
        {
            const int rsa = 1;
            var cspParameters = new CspParameters(rsa);
            cspParameters.Flags = CspProviderFlags.UseMachineKeyStore;
            cspParameters.KeyContainerName = "My Keys";
            var rsaCryptoServiceProvider = new RSACryptoServiceProvider(cspParameters);
            byte[] encrypted = rsaCryptoServiceProvider.Encrypt(new UnicodeEncoding().GetBytes(input), true);

            return encrypted;
        }
        public static string DecryptRsa(byte[] input)
        {
            const int rsa = 1;
            var cspParameters = new CspParameters(rsa);
            cspParameters.Flags = CspProviderFlags.UseMachineKeyStore;
            cspParameters.KeyContainerName = "My Keys";
            var rsaCryptoServiceProvider = new RSACryptoServiceProvider(cspParameters);
            var decrypted = rsaCryptoServiceProvider.Decrypt(input, true);

            return new UnicodeEncoding().GetString(decrypted);
        }
    }
}
