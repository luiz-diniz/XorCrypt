using System;
using System.Collections.Generic;
using XorCrypt.Exceptions;

namespace XorCrypt.Entities
{
    public class XOR
    {
        public string key { get; set; }
        public string text { get; set; }

        public XOR(string key, string text)
        {
            this.key = key;
            this.text = text;
        }

        public string EncryptDecrypt()
        {
            if (!String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(text))
            {
                if (key.Length >= text.Length)
                {
                    List<char> encryptedText = new List<char>();                

                    for (int i = 0; i < text.Length; i++)
                    {
                        int character = text[i] ^ key[i];
                        encryptedText.Add((char)character);
                        i++;
                    }

                    return encryptedText.ToString();
                }
                else
                {
                    throw new InvalidConfigurationException("The key must be larger than the message !");
                }
            }
            else
            {
                throw new InvalidConfigurationException("Insert a key and a text to Encrypt or Decrypt.");
            }
        }
    }
}