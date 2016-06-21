using Szyfrant.cryptographers;

namespace Szyfrant
{
    public class CipherFacade
    {
        public string AESEncrypt(string text)
        {
            AESCipher cipher = new AESCipher();
            return cipher.Encrypt(text);
        }
        public string AESDeccrypt(string text)
        {
            AESCipher aes = new AESCipher();
            return aes.Decrypt(text);
        }
        public string CaesarEncrypt(string text)
        {
            CaesarCipher caesar = new CaesarCipher();
            return caesar.Encrypt(text);
        }
        public string CaesarDecrypt(string text)
        {
            CaesarCipher caesar = new CaesarCipher();
            return caesar.Decrypt(text);
        }
        public string Rot13Encrypt(string text)
        {
            Rot13Cipher rot13 = new Rot13Cipher();
            return rot13.Encrypt(text);
        }
        public string Rot13Decrypt(string text)
        {
            Rot13Cipher rot13 = new Rot13Cipher();
            return rot13.Decrypt(text);
        }
        public string RSAEncrypt(string text)
        {
            AESCipher rsa = new AESCipher();
            return rsa.Encrypt(text);
        }
        public string RSADecrypt(string text)
        {
            AESCipher rsa = new AESCipher();
            return rsa.Decrypt(text);
        }
    }
}
