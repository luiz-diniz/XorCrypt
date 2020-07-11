using System;
using XorCrypt.Entities;

namespace XorCrypt.Executor
{
    public class Executor
    {
        public static string GenerateKey(int keySize)
        {
            try
            {
                KeyManager keyManager = new KeyManager(keySize);
                return keyManager.GenerateKey();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string EncryptDecryptText(string key, string text)
        {
            try
            {
                XOR xor = new XOR(key, text);
                string finalText = xor.EncryptDecrypt();
                return finalText;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}