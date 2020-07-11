using System;
using System.Collections.Generic;
using System.Linq;
using XorCrypt.Exceptions;

namespace XorCrypt.Entities
{
    public class XOR
    {
        public string key { get; set; }
        public string text { get; set; }

        private List<char> _encryptedText;

        public XOR(string key, string text)
        {
            this.key = key;
            this.text = text;

            _encryptedText = new List<char>();
        }

        public string EncryptDecrypt()
        {
            if (!String.IsNullOrEmpty(key) && !String.IsNullOrEmpty(text))
            {
                if (key.Length >= text.Length)
                {
                    int i = 0;

                    foreach (char c in text)
                    {
                        int character = c ^ key[i];
                        _encryptedText.Add((char)character);
                        i++;
                    }

                    return new string(_encryptedText.ToArray());
                }
                else
                {
                    throw new InvalidConfigurationException("The key must be larger than the text.");
                }
            }
            else
            {
                throw new InvalidConfigurationException("Insert a key and a text to Encrypt or Decrypt.");
            }
        }
    }
}