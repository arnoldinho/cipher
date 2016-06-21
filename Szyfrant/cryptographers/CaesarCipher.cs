namespace Szyfrant.cryptographers
{
    public class CaesarCipher:ICipher
    {
        public string Encrypt(string unencrypted)
        {
            string UserOutput = null;
            char[] A = null;
            A = unencrypted.ToCharArray();
            int temp;

            for (int i = 0; i < unencrypted.Length; i++)
            {
                    temp = (int)(A[i] + 3);
                    UserOutput += (char)temp;
            }
            return UserOutput;
        }

        public string Decrypt(string encrypted)
        {
            string UserOutput = null;
            char[] A = null;
            A = encrypted.ToCharArray();
            int temp;

            for (int i = 0; i < encrypted.Length; i++)
            {
                    temp = (int)(A[i] - 3);
                    UserOutput += (char)temp;
            }
            return UserOutput;
        }
    }
}
