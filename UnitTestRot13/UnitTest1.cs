using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Szyfrant.cryptographers;


namespace UnitTestRot13
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EncryptDecrypt()
        {
            // Arrange
            var subject = new Rot13Cipher();
            var originalString = "The quick brown fox jumps over the lazy dog";

            // Act
            var encryptedString1 = subject.Encrypt(originalString);
            var encryptedString2 = subject.Encrypt(originalString);
            var decryptedString1 = subject.Decrypt(encryptedString1);
            var decryptedString2 = subject.Decrypt(encryptedString2);

            // Assert
            Assert.AreEqual(originalString, decryptedString1, "Decrypted string should match original string");
            Assert.AreEqual(originalString, decryptedString2, "Decrypted string should match original string");
            Assert.AreNotEqual(originalString, encryptedString1, "Encrypted string should not match original string");
        }
    }
}
