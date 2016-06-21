namespace Szyfrant.cryptographers
{
    public interface ICipher
    {
        string Encrypt(string unencrypted);
        string Decrypt(string encrypted);
    }
}
